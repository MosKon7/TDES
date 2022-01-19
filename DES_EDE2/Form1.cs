using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DES_EDE2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl_EDE.Visible = true;
        }
        /*
         * ЧАСТЬ ФУНКЦИОНАЛА И КНОПК НА ФОРМЕ НЕ РАБОТАЕТ
         */

        /*
         * Размер блока и символа
         * подгоняем под UTF8 
         */
        private const int sizeOfBlock = 64;
        private const int sizeOfChar = 8;

        private const int quantityOfRounds = 16; //количество раундов


        /*
         * Переменные - Костыли
         * 
         * ДЛЯ ИЗМЕНЕНИЯ TDES на DES нужно изменить размер rounds на string[quantityOfRounds]
         */
        
        bool firstStage = true;

        string encrypt = ""; 
        string decrypt = "";

        string[] rounds = new string[quantityOfRounds*3];
            

        //######################
        //  Обработчик нажатия кнопк
        //######################
        private void button2_Click(object sender, EventArgs e)
        {
            //проверка что есть ключи
            if (textKey1.Text.Length > 0 && textKey2.Text.Length > 0)
            {   // очистка блоков вывода
                textBoxOut.Text = "";
                textBoxE.Text = "";
                textBoxD.Text = "";
                textBoxE2.Text = "";
                firstStage = true;
                // оистка мусора
                for (int i = 0; i < quantityOfRounds; i++)
                {
                    rounds[i] = "";
                }

                string message = "";
                string key1 = textKey1.Text; // считываем ключи
                string key2 = textKey2.Text;
                //подгоняем размер
                while (key1.Length != sizeOfChar && key1.Length < sizeOfChar) key1 += "#";
                while (key2.Length != sizeOfChar && key2.Length < sizeOfChar) key2 += "#";

                //Считываем исходный текст
                StreamReader sr = new StreamReader("in.txt");
                while (!sr.EndOfStream)
                {
                    message += sr.ReadLine();
                }   sr.Close();

                // Подгоняем сообщение до нужного размера
                while (message.Length % sizeOfChar != 0) message += "#";

                // Вывод воды в интерфес
                textBoxOut.Text = "Исходное сообщение: '" + message + "'" + System.Environment.NewLine;
                if (checkBoxDesc.Checked) {
                    textBoxOut.Text += "Количество блоков: " + message.Length / sizeOfChar + System.Environment.NewLine;
                    textBoxOut.Text += "Количество символов в блоке: " + sizeOfBlock / sizeOfChar + System.Environment.NewLine;
                }


                //ПЕРВЫЙ ЭТАП ШИФРОВАНИЯ
                //         принимает( Сообщение, ключ, этап(для вывода))
                string E = DESEncryption(message, key1, 1);
                if (checkBoxDesc.Checked) // ВЫВОД
                    textBoxOut.Text += System.Environment.NewLine + "Этап E: '" + E + "'" + System.Environment.NewLine;

                //ВТОРОЙ ЭТАП РАСШИФРОВАНИЯ
                string D = DESDecryption(E, key2, 2);
                if (checkBoxDesc.Checked)// ВЫВОД
                    textBoxOut.Text += "Этап D: '" + D + "'" + System.Environment.NewLine;

                //ТРЕТИЙ ЭТАП ШИФРОВАНИЯ
                encrypt = DESEncryption(D, key1, 3);// ВЫВОД
                textBoxOut.Text += "Зашифрованое сообщение: '" + encrypt + "'" + System.Environment.NewLine;

                // ВЫВОД МУСОРА
                for (int i = 0; i < quantityOfRounds * 3; i++)
                {
                    if(i < 16)
                    {
                        textBoxE.Text += System.Environment.NewLine + "Raund " + (i + 1) + ":  " + rounds[i];
                    }
                    else if (i >= 16 & i < 32)
                    {
                        textBoxD.Text += System.Environment.NewLine + "Raund " + (i + 1 - quantityOfRounds) + ":  " + rounds[i];
                    }
                    else
                    {
                        textBoxE2.Text += System.Environment.NewLine + "Raund " + (i + 1 - quantityOfRounds*2) + ":  " + rounds[i];
                    }
                }

                //СОХРАНЕНИЕ
                StreamWriter sw = new StreamWriter("out1.txt");
                sw.WriteLine(encrypt);
                sw.Close();

                Process.Start("out1.txt");
            }
            else
                MessageBox.Show("Введите корректные данные!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textKey2.Text.Length > 0)
            {
                textBoxE.Text = "";
                textBoxD.Text = "";
                textBoxE2.Text = "";

                for (int i = 0; i < quantityOfRounds*3; i++)
                {
                    rounds[i] = "";
                }

                string key1 = textKey1.Text;
                string key2 = textKey2.Text;
                while (key1.Length != 8 && key1.Length < 8) key1 += "#";
                while (key2.Length != 8 && key2.Length < 8) key2 += "#";

                string D = DESDecryption(encrypt, key1, 1);
                string E = DESEncryption(D, key2, 2);
                decrypt = DESDecryption(E, key1, 3);
                textBoxOut.Text += System.Environment.NewLine + "Расшифрованное сообщение: '" + decrypt + "'" + System.Environment.NewLine;


                for (int i = 0; i < quantityOfRounds * 3; i++)
                {
                    if (i < 16)
                    {
                        textBoxE.Text += System.Environment.NewLine + "Raund " + (i + 1) + ":  " + rounds[i];
                    }
                    else if (i >= 16 & i < 32)
                    {
                        textBoxD.Text += System.Environment.NewLine + "Raund " + (i + 1 - quantityOfRounds) + ":  " + rounds[i];
                    }
                    else
                    {
                        textBoxE2.Text += System.Environment.NewLine + "Raund " + (i + 1 - quantityOfRounds * 2) + ":  " + rounds[i];
                    }
                }

                
                StreamWriter sw = new StreamWriter("out2.txt");
                sw.WriteLine(decrypt);
                sw.Close();

                Process.Start("out2.txt");
            }
            else
                MessageBox.Show("Введите корректные данные!");
        }





        //***********************************************
        string DESEncryption(string message, string key, int stage)
        {
            message = ConvertToBinary(message); // Перевод сообщения в бинар

            StringBuilder sb = new StringBuilder();
            string[] keys = KeyGenerator(ConvertToBinary(key)); // Генерация ПОДключей сконвертированых в бинар

            for (int i = 0; i < message.Length; i += sizeOfBlock) // ПРОБЕЖКА ПО СООБЩЕНИЕ С ШАГОМ РАЗМЕРА БЛОКА
            {
                // ВЫВОД ИНФЫ О БЛОКАХ
                if (firstStage)
                {
                    if (checkBoxBlock.Checked)
                    {
                        textBoxOut.Text += System.Environment.NewLine + "Block " + (i / sizeOfBlock + 1) + ": " + BinaryToString(message.Substring(i, sizeOfBlock));
                        if (checkBoxBinout.Checked)
                        {
                            textBoxOut.Text += "    --> " + message.Substring(i, sizeOfBlock);
                        }
                    }
                }

                //  ПЕРЕМЕННЫЕ,                   ВЫБОРКА БЛОКА И IP перестановка
                string right, left, tmp, part = Transposition(message.Substring(i, sizeOfBlock), IP);
                // ДЕЛЕНИЕ НА ЧАСТИ
                right = part.Substring(32, part.Length / 2);
                left = part.Substring(0, part.Length / 2);

                // "СЕТЬ ФЕЙСТЕЛЯ"
                for (int k = 0; k < quantityOfRounds; k++)
                {
                    tmp = left;
                    left = right;
                    right = XOR(tmp, f(right, keys[k]));
                    // МУСОР
                    rounds[quantityOfRounds * (stage-1) + k] += BinaryToString(Transposition(right + left, FP));
                }
                // Конечная FP перестановка
                sb.Append(Transposition(right + left, FP)); 
            }

            firstStage = false;
            //  Перевод из бинара в строку и вывод
            return BinaryToString(sb.ToString());
        }

        string DESDecryption(string message, string key, int stage)
        {
            message = ConvertToBinary(message);
            StringBuilder sb = new StringBuilder();
            string[] keys = KeyGenerator(ConvertToBinary(key));
            for (int i = 0; i < message.Length; i += sizeOfBlock)
            {
                string part = Transposition(message.Substring(i, sizeOfBlock), IP);
                string right = part.Substring(0, part.Length / 2);
                string left = part.Substring(32, part.Length / 2);
                string tmp;
                for (int k = quantityOfRounds-1; k >= 0; k--)
                {
                    tmp = right;
                    right = left;
                    left = XOR(tmp, f(left, keys[k]));
                    rounds[quantityOfRounds * stage - (k+1)] += BinaryToString(Transposition(left + right, FP));
                }
                sb.Append(Transposition(left + right, FP));
            }
            return BinaryToString(sb.ToString());
        }
        public static string BinaryToString(string data)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += sizeOfChar)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, sizeOfChar), 2));
            }
            return Encoding.Default.GetString(byteList.ToArray());

        }

        static string f(string RightPart, string key) //+
        {
            RightPart = Transposition(RightPart, table);
            RightPart = XOR(key, RightPart);

            // ПЕРЕСТАНОВКи ПО ТАБЛИЦЕ S
            StringBuilder sb = new StringBuilder();
            for (int i = 0, j = 0; i < sizeOfChar; i++, j += 6)
            {
                int row = Convert.ToInt32(Convert.ToString(RightPart.Substring(j, 6)[0]) + Convert.ToString(RightPart.Substring(j, 6)[5]), 2);
                int coloumn = Convert.ToInt32(RightPart.Substring(j, 6).Substring(1, 4), 2);

                sb.Append(Convert.ToString(S[i][row, coloumn], 2).PadLeft(4, '0'));
            }

            RightPart = Transposition(sb.ToString(), tableP);

            return RightPart;
        }

        static string ConvertToBinary(string message)
        {
            StringBuilder str = new StringBuilder("");
            byte[] test = Encoding.Default.GetBytes(message);
            for (int i = 0; i < message.Length; i++)
            {
                str.Append(Convert.ToString(test[i], 2).PadLeft(8, '0'));
            }
            return str.ToString();
        }

        // ТОПОРНЫЙ СПОСОБ XOR-а СТРОКИ
        static string XOR(string str1, string str2)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str2.Length; i++)
                sb.Append((byte)(str2[i] ^ str1[i]));
            return sb.ToString();
        }
        // МЕТОД СДВИГОВ ПО ТАБЛИЦАМ
        static string Transposition(string str, int[] array)
        {
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(str[array[i] - 1]);
            }
            return sb.ToString();
        }

        //ГЕНЕРАЦИЯ ПОДКЛЮЧЕЙ
        static string[] KeyGenerator(string key)
        {

            string[] result = new string[quantityOfRounds];
            int[] move = { 1, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1 };

            key = Transposition(key, TableG);
            string G0 = key.Substring(0, key.Length / 2);
            string D0 = key.Substring(key.Length / 2, key.Length / 2);

            for (int i = 0; i < quantityOfRounds; i++)
            {
                G0 = MoveLeft(G0, move[i]);
                D0 = MoveLeft(D0, move[i]);
                result[i] = Transposition(G0 + D0, TableH);

            }
            return result;
        }

        static string MoveLeft(string str, int bit)
        {
            for (int i = 0; i < bit; i++) str = str.Remove(0, 1) + "0";
            return str;
        }

        /*
         * ТАБЛИЦЫ СДВИГОВ
         */
        static readonly int[] TableG = { 57, 49, 41, 33, 25, 17, 9,
                                         1, 58, 50, 42, 34, 26, 18,
                                         10, 2, 59, 51, 43, 35, 27,
                                         19, 11, 3, 60, 52, 44, 36,
                                         63, 55, 47, 39, 31, 23, 15,
                                         7, 62, 54, 46, 38, 30, 22,
                                         14, 6, 61, 53, 45, 37, 29,
                                         21, 13, 5, 28, 20, 12, 4};
        static readonly int[] TableH = { 14, 17, 11, 24, 1, 5, 3, 28,
                                        15, 6, 21, 10, 23, 19, 12, 4,
                                        26, 8, 16, 7, 27, 20, 13, 2,
                                        41, 52, 31, 37, 47, 55, 30, 40,
                                        51, 45, 33, 48, 44, 49, 39, 56,
                                        34, 53, 46, 42, 50, 36, 29, 32};
        static readonly int[] table = { 32, 1, 2, 3, 4, 5,
                                        4, 5, 6, 7, 8, 9,
                                        8, 9, 10, 11, 12, 13,
                                        12, 13, 14, 15, 16, 17,
                                        16, 17, 18, 19, 20, 21,
                                        20, 21, 22, 23, 24, 25,
                                        24, 25, 26, 27, 28, 29,
                                        28, 29, 30, 31, 32, 1};
        static readonly int[] tableP = {16, 7, 20, 21, 29, 12, 28, 17,
                                        1, 15, 23, 26, 5, 18, 31, 10,
                                        2, 8, 24, 14, 32, 27, 3, 9,
                                        19, 13, 30, 6, 22, 11, 4, 25};
        static readonly int[][,] S = new int[8][,]
            {
                new int[,] { {14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7 },
                             {0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8},
                             {4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0},
                             {15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13 }},
                new int[,] { {15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10 },
                             {3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5},
                             {0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15},
                             {13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9 }},
                new int[,] { {10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8 },
                             {13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1},
                             {13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7},
                             {1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12 }},
                new int[,] { {7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15 },
                             {13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9},
                             {10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4},
                             {3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14 }},
                new int[,] { {2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9 },
                             {14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6},
                             {4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14},
                             {11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3 }},
                new int[,] { {12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11 },
                             {10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8},
                             {9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6},
                             {4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13 }},
                new int[,] { {4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1 },
                             {13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6},
                             {1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2},
                             {6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12 }},
                new int[,] { {13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7 },
                             {1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2},
                             {7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8},
                             {2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11 }}
            };
        static readonly int[] IP = { 58, 50, 42, 34, 26, 18, 10, 2,
                                      60, 52, 44, 36, 28, 20, 12, 4,
                                      62, 54, 46, 38, 30, 22, 14, 6,
                                      64, 56, 48, 40, 32, 24, 16, 8,
                                      57, 49, 41, 33, 25, 17, 9,  1,
                                      59, 51, 43, 35, 27, 19, 11, 3,
                                      61, 53, 45, 37, 29, 21, 13, 5,
                                      63, 55, 47, 39, 31, 23, 15, 7 };
        static readonly int[] FP = {40, 8, 48, 16, 56, 24, 64, 32,
                                      39, 7, 47, 15, 55, 23, 63, 31,
                                      38, 6, 46, 14, 54, 22, 62, 30,
                                      37, 5, 45, 13, 53, 21, 61, 29,
                                      36, 4, 44, 12, 52, 20, 60, 28,
                                      35, 3, 43, 11, 51, 19, 59, 27,
                                      34, 2, 42, 10, 50, 18, 58, 26,
                                      33, 1, 41,  9, 49, 17, 57, 25 };






        private void checkBoxIn_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIn.Checked == true)
            {
                btnLoadText.Enabled = false;
                textBoxIn.Enabled = false;
            }
            else
            {
                btnLoadText.Enabled = true;
                textBoxIn.Enabled = true;
            }
        }

        private void checkBoxDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDesc.Checked == true)
            {
                checkBoxBlock.Enabled = true;
            }
            else
            {
                checkBoxBinout.Enabled = false;
                checkBoxBinout.Checked = false;
                checkBoxBlock.Enabled = false;
                checkBoxBlock.Checked = false;
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            textKey1.Text = "Алгоритм";
            textKey2.Text = "ДессAlgo";
        }

        private void checkBoxBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBlock.Checked == true)
            {
                checkBoxBinout.Enabled = true;
            }
            else
            {
                checkBoxBinout.Enabled = false;
            }
        }
    }
}


