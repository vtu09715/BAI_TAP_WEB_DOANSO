using System;
using VDT.GuessLib;

namespace VDT.GuessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessEngine engine = new GuessEngine();
            Console.WriteLine("VDT Guess Game - Console (target .NET 2.0)");
            Console.WriteLine(engine.Signature);
            Console.WriteLine("Đã tạo số bí mật. Hãy đoán số (1-100). Gõ 'exit' để thoát, 'new' để tạo số mới.");

            while (true)
            {
                Console.Write("Nhập số: ");
                string input = Console.ReadLine();
                if (input == null)
                {
                    break;
                }
                input = input.Trim().ToLower();
                if (input == "exit")
                {
                    Console.WriteLine("Kết thúc. " + engine.Signature);
                    break;
                }
                if (input == "new")
                {
                    engine.ResetSecret();
                    Console.WriteLine("Số mới đã tạo.");
                    continue;
                }

                int guess;
                if (!Int32.TryParse(input, out guess))
                {
                    Console.WriteLine("Vui lòng nhập số nguyên hợp lệ (1-100).");
                    continue;
                }

                // Use engine
                string result = engine.Guess(guess);
                Console.WriteLine(result);

                if (result.StartsWith("Chính xác"))
                {
                    Console.WriteLine("Bạn thắng! Gõ 'new' để chơi lại hoặc 'exit' để thoát.");
                }
            }
        }
    }
}
