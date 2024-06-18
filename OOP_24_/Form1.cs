using System;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace OOP_24_
{
    public partial class Form1 : Form
    {
        private Thread thread1; // ���� ��� �������� ���������� RC5
        private Thread thread2; // ���� ��� �������� ��������� MD5
        private Thread thread3; // ���� ��� �������� ���������� ������

        public Form1()
        {
            InitializeComponent();
        }

        #region SXAL8/MBAL
        private void SXAL8_MBAL()
        {
            try
            {

                string word = textBox1.Text; // �������� ����� ��� ���������� � ���������� ����
                byte[] _key = GetKey("password"); // �������� ���� ��� ����������
                string encryptedWord = Convert.ToBase64String(Encrypt(word)); // ������� �����

                label1.Invoke((MethodInvoker)delegate ()
                {
                    label1.Text = encryptedWord;
                }); // ³��������� ������������ �����
            }
            catch (Exception ex) { MessageBox.Show($"{ex.Message}"); } // ������� �������

        }

        private byte[] EncryptBlock(byte[] block) // ���������� ������ �����
        {
            byte[] Key = Encoding.ASCII.GetBytes("password"); // ������ ���� ��� ����������
            byte[] encryptedBlock = new byte[8];
            for (int i = 0; i < 8; i++)
            {
                encryptedBlock[i] = (byte)(block[i] ^ Key[i]); // �������� XOR � ������
            }
            return encryptedBlock;
        }

        private byte[] Encrypt(string input)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            int paddedLength = ((inputBytes.Length + 8 - 1) / 8) * 8;
            byte[] paddedInput = new byte[paddedLength];
            Array.Copy(inputBytes, paddedInput, inputBytes.Length);

            byte[] encryptedBytes = new byte[paddedLength];
            for (int i = 0; i < paddedLength; i += 8)
            {
                byte[] block = new byte[8];
                Array.Copy(paddedInput, i, block, 0, 8);
                byte[] encryptedBlock = EncryptBlock(block);
                Array.Copy(encryptedBlock, 0, encryptedBytes, i, 8);
            }
            return encryptedBytes;
        }

        private byte[] GetKey(string password)
        {
            using (var sha256 = SHA256.Create()) // ������������� �������� ��������� SHA256 ��� ��������� �����
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password)); // ��������� ��������� ����
            }
        }
        #endregion

        #region HAVAL
        private void HAVAL() //�������� ��� ���������� MD3, ���� ��� ��������� HAVAL ��������� ��������� �������� BouncyCastle. ��� �� ��������� ���� ����� �� ������.
        {
            try
            {
                var md3 = MD5.Create(); // ��������� ��'��� MD5
                var hash = md3.ComputeHash(Encoding.UTF8.GetBytes(textBox2.Text)); // ������ �������� �����
                string hashString = BitConverter.ToString(hash).Replace("-", "").ToLower(); // ������������ ��� � �����

                label2.Invoke((MethodInvoker)delegate ()
                {
                    label2.Text = hashString;
                }); // ³��������� ���
            }
            catch (Exception ex) { MessageBox.Show($"{ex.Message}"); } // ������� �������
        }
        #endregion

        #region Cesar
        private void Cesar()
        {
            //try
            //{
            generateKeys(out byte[] publicKey1, out byte[] privateKey1);
            generateKeys(out byte[] publicKey2, out byte[] privateKey2);
            byte[] key1 = DeriveKey(publicKey2, privateKey1);

            string plaintext = textBox3.Text;
            byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);

            // ����������
            byte[] ciphertext = Encrypt1(key1, plaintextBytes);

            label3.Invoke((MethodInvoker)delegate ()
            {
                label3.Text = Convert.ToBase64String(ciphertext);
            });
            // ³��������� ������������ �����
            //}
            //catch (Exception ex) { MessageBox.Show($"{ex.Message}"); } // ������� �������
        }
        public static byte[] Encrypt1(byte[] key, byte[] plaintext)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.Padding = PaddingMode.None;

                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                using (MemoryStream ms = new MemoryStream())
                {
                    byte[] iv = aes.IV;
                    ms.Write(iv, 0, iv.Length);

                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(plaintext, 0, plaintext.Length);
                    }

                    return ms.ToArray();
                }
            }
        }
        public static void generateKeys(out byte[] publicKey, out byte[] privateKey)
        {
            using (ECDiffieHellmanCng diffieHellman = new ECDiffieHellmanCng(256))
            {
                diffieHellman.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                diffieHellman.HashAlgorithm = CngAlgorithm.Sha256;
                privateKey = diffieHellman.Key.Export(CngKeyBlobFormat.EccPrivateBlob);
                publicKey = diffieHellman.PublicKey.ToByteArray();
            }
        }

        public static byte[] DeriveKey(byte[] otherPartyPublicKey, byte[] privateKey)
        {
            using (ECDiffieHellmanCng diffieHellman = new ECDiffieHellmanCng(CngKey.Import(privateKey, CngKeyBlobFormat.EccPrivateBlob)))
            {
                diffieHellman.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                diffieHellman.HashAlgorithm = CngAlgorithm.Sha256;
                return diffieHellman.DeriveKeyMaterial(CngKey.Import(otherPartyPublicKey, CngKeyBlobFormat.EccPublicBlob));
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty; // ������� ��������� ���������

            thread1?.Interrupt(); // ��������� ��������� ���� (���� �� ����)
            thread1 = new Thread(new ThreadStart(SXAL8_MBAL)); // ��������� ����� ���� ��� �������� ���������� RC5
            thread1.Start(); // ��������� ����
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = string.Empty; // ������� ��������� ���������

            thread2?.Interrupt(); // ��������� ��������� ���� (���� �� ����)
            thread2 = new Thread(new ThreadStart(HAVAL)); // ��������� ����� ���� ��� �������� ��������� MD5
            thread2.Start(); // ��������� ����
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = string.Empty; // ������� ��������� ���������

            thread3?.Interrupt(); // ��������� ��������� ���� (���� �� ����)
            thread3 = new Thread(new ThreadStart(Cesar)); // ��������� ����� ���� ��� �������� ���������� ������
            thread3.Start(); // ��������� ����
        }

        private void button6_Click(object sender, EventArgs e)
        {
            thread3?.Interrupt(); // ��������� ���� ��� �������� ���������� ������
        }

        private void button4_Click(object sender, EventArgs e)
        {
            thread1?.Interrupt(); // ��������� ���� ��� �������� ���������� RC5
        }

        private void button5_Click(object sender, EventArgs e)
        {
            thread2?.Interrupt(); // ��������� ���� ��� �������� ��������� MD5
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // ��������� �� ������
            thread1?.Interrupt();
            thread2?.Interrupt();
            thread3?.Interrupt();

            // ������� �� ����������
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label3.Text = string.Empty;

            // ��������� ��� ������ ��� ����� �������� � ��������� ��
            thread1 = new Thread(new ThreadStart(SXAL8_MBAL));
            thread2 = new Thread(new ThreadStart(HAVAL));
            thread3 = new Thread(new ThreadStart(Cesar));

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // ��������� �� ������
            thread1?.Interrupt();
            thread2?.Interrupt();
            thread3?.Interrupt();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ��������� �� ������ ��� ������� �����
            thread1?.Abort();
            thread2?.Abort();
            thread3?.Abort();
        }


    }
}
