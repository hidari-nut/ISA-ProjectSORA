using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SORA_Class
{
    public class RSA
    {
        public static byte[] RSAEncrypt(byte[] DataToEncrypt, byte[] recipientPublicKey)
        {
            try
            {
                byte[] encryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    int bytesRead = 0;

                    //Import the Public Key (of the Recipient)
                    RSA.ImportRSAPublicKey(recipientPublicKey, out bytesRead);

                    //Encrypt the passed byte array with SHA512 OAEP padding.
                    encryptedData = RSA.Encrypt(DataToEncrypt, RSAEncryptionPadding.Pkcs1);
                }
                return encryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {                
                throw new Exception(e.Message);
                return null;

            }
        }

        public static byte[] RSADecrypt(byte[] DataToDecrypt, byte[] recipientPrivateKey)
        {
            try
            {
                byte[] decryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    int bytesRead = 0;

                    //Import the Private key (of the Receiving user)
                    RSA.ImportPkcs8PrivateKey(recipientPrivateKey, out bytesRead);

                    //Decrypt the passed byte array with SHA512 OAEP padding.  
                    decryptedData = RSA.Decrypt(DataToDecrypt, RSAEncryptionPadding.Pkcs1);
                }
                return decryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                throw new Exception(e.Message);
                return null;
            }
        }
    }
}
