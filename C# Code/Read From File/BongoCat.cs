using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace Read_From_File
{
    class PlayBongo
    {
        private string _allowedInstruments = "ADCFBQWERTYUIOP0123456789";
        private string _fileName = "BongoCat.txt";
        private string[] _lines;

        public PlayBongo()
        {
            Thread.Sleep(1000);
            _lines = ReadFile();
            PrintLines();
            Play();
        }

        private string[] ReadFile()
        {
            var lines = new string[] { "EE3 0 9 8 6 368", "QQ3 0 9 8 6 368" };
            if (File.Exists(_fileName))
            {
                var readText = File.ReadAllLines(_fileName);
                return readText;
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(_fileName))
                {
                    writer.WriteLine(lines[0]);
                    writer.WriteLine(lines[1]);
                }
            }
            return lines;
        }

        private void PrintLines()
        {
            foreach (var line in _lines)
            {
                Console.WriteLine(line);
            }
        }

        private void Play()
        {
            var sim = new InputSimulator();
            foreach (var line in _lines)
            {
                foreach (var note in line)
                {
                    switch (note)
                    {
                        case 'A':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_A);
                            break;
                        case 'D':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_D);
                            break;
                        case 'C':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_C);
                            break;
                        case 'F':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_F);
                            break;
                        case 'B':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_B);
                            break;
                        case '0':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_0);
                            break;
                        case '1':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_1);
                            break;
                        case '2':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_2);
                            break;
                        case '3':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_3);
                            break;
                        case '4':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_4);
                            break;
                        case '5':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_5);
                            break;
                        case '6':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_6);
                            break;
                        case '7':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_7);
                            break;
                        case '8':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_8);
                            break;
                        case '9':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_9);
                            break;
                        case 'Q':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_Q);
                            break;
                        case 'W':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_W);
                            break;
                        case 'E':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_E);
                            break;
                        case 'R':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_R);
                            break;
                        case 'T':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_T);
                            break;
                        case 'Y':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_Y);
                            break;
                        case 'U':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_U);
                            break;
                        case 'I':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_I);
                            break;
                        case 'O':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_O);
                            break;
                        case 'P':
                            sim.Keyboard.KeyPress(VirtualKeyCode.VK_P);
                            break;
                        case '~':
                            sim.Keyboard.KeyPress(VirtualKeyCode.SPACE);
                            break;
                        default:
                            Thread.Sleep(100);
                            break;
                    }
                    Thread.Sleep(100);
                }
            }
        }
    }
}
