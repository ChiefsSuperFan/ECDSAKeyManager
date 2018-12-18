using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace ECDSAKeyManager
{
    public class UserAccount
    {
        private const int ADDRESS_LENGTH = 40;

        public string ECDSAPrivateKey { get; private set; }
        public string ECSDAPublicKey { get; private set; }
        public string UserAddress { get; private set; }

        public UserAccount()
        {

            CngKeyCreationParameters keyCreationParameters = new CngKeyCreationParameters();
            keyCreationParameters.ExportPolicy = CngExportPolicies.AllowPlaintextExport;
            keyCreationParameters.KeyUsage = CngKeyUsages.Signing;

            CngKey key = CngKey.Create(CngAlgorithm.ECDsaP256, null, keyCreationParameters);



            ECDsaCng dsa = new ECDsaCng(key); //dsa = Digital Signature Algorithm
            byte[] privateKey = dsa.Key.Export(CngKeyBlobFormat.EccPrivateBlob);

            ECDSAPrivateKey = BitConverter.ToString(privateKey).Replace("-", String.Empty);



            //create public key
            byte[] publicKey = dsa.Key.Export(CngKeyBlobFormat.EccPublicBlob);

            ECSDAPublicKey = BitConverter.ToString(publicKey).Replace("-", String.Empty);



            //we calculate the hashvalue by slicing the end off of the public key
            string hashValue = ECDSAOperations.GetHashValue(publicKey);

            int hashLength = hashValue.Length;
            UserAddress = "0x" + hashValue.Substring(hashLength - ADDRESS_LENGTH);

        }
    }

    public static class ECDSAOperations
    {
        public static string GetHashValue(byte[] InputValue)
        {
            SHA256Managed sha = new SHA256Managed();
            byte[] checksum = sha.ComputeHash(InputValue);



            return BitConverter.ToString(checksum).Replace("-", String.Empty);



        }

        public static string GetSha256FileHash(string FileURL)
        {

            try
            {
                using (FileStream stream = File.OpenRead(FileURL))
                {
                    SHA256Managed sha = new SHA256Managed();
                    byte[] checksum = sha.ComputeHash(stream);




                    return BitConverter.ToString(checksum).Replace("-", String.Empty);
                }



            }
            catch
            {

                return "";
            }
        }

        public static bool VerifySignature(string Message, string Signature, string PublicKey)
        {

            try
            {
                byte[] publicKey = ConvertToBytes(PublicKey);
                byte[] message = ConvertToBytes(Message);
                byte[] signature = ConvertToBytes(Signature);

                bool verified = false;
                using (CngKey importedKey = CngKey.Import(publicKey, CngKeyBlobFormat.EccPublicBlob))
                {
                    using (ECDsaCng importedDSA = new ECDsaCng(importedKey))
                    {
                        verified = importedDSA.VerifyData(message, signature);
                    }
                }


                return verified;



            }
            catch
            {
                return false;
            }


        }

        public static string SignMessage(string PrivateKey, string Message)
        {


            try
            {
                byte[] privateKey = ConvertToBytes(PrivateKey);
                byte[] message = ConvertToBytes(Message);



                using (CngKey importedKey = CngKey.Import(privateKey, CngKeyBlobFormat.EccPrivateBlob))
                {
                    using (ECDsaCng importedDSA = new ECDsaCng(importedKey))
                    {
                        byte[] signed = importedDSA.SignData(message);
                        string messageAuthentication = BitConverter.ToString(signed).Replace("-", String.Empty);

                        return messageAuthentication;
                    }
                }





            }
            catch
            {
                return "";
            }
        }

        private static byte[] ConvertToBytes(string InputValue)
        {
            //we are often converting byte arrays to strings
            //this ACCURATELY converts them back!

            int arrayLength = InputValue.Length / 2;
            //the inputvalues will always be twice the length of the
            //byte array because when you use bit converter, each byte
            //is converted to a 2 character hex number
            byte[] convert = new byte[arrayLength];
            int index = -1;

            try
            {


                char[] inputParts = InputValue.ToCharArray();
                string hex = "";
                foreach (char part in inputParts)
                {


                    hex += part.ToString();
                    if (hex.Length == 2)
                    {
                        index++;
                        convert[index] = Convert.ToByte(hex, 16);

                        hex = "";
                    }
                }
                return convert;

            }
            catch
            {
                return convert;
            }
        }

    }
}
