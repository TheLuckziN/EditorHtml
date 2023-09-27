using System;

namespace EditorHtml {
    public static class Menu {
        public static void Show() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen() {
            Mainline();
            MidLine();
            Mainline();
        }

        public static void Mainline() {
            Console.Write("+");
            for(int i = 0; i <= 30; i++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }

        public static void MidLine() {
                for(int lines = 0; lines <= 10; lines++){
                Console.Write("|");
                for(int i = 0; i <= 30; i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");    
            }
        }

        public static void WriteOptions() {
            Console.SetCursorPosition(3,2); //(Coluna, Linha)
            Console.WriteLine("Luckzin Studio Html");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("-------------------");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma opção: ");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("[1] - Novo Arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("[2] - Abrir");
            Console.SetCursorPosition(3,8);
            Console.WriteLine("[0] - Sair");
            Console.SetCursorPosition(3,10);
            Console.Write("Opção: ");
        }
    
        public static void HandleMenuOption(short option) {
            switch(option) {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0: Valeu(); break;
                default: Show(); break;
            }        
        }

        public static void Valeu() {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Muito obrigado por utilizar meu sistema. Espero que tenha gostado e volte a usar!");
            Console.WriteLine("Abraço do Luckzin :)");
            Console.WriteLine("---------------------------------------------------------------------------------");
            System.Environment.Exit(0);
        }
    }
}