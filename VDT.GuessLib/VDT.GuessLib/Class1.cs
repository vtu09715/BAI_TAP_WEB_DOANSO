using System;

namespace VDT.GuessLib
{
    /// <summary>
    /// VDT Guess Engine - .NET Framework 2.0 compatible
    /// Created by: VU DUC TU (VDT)
    /// Personal signature: VDT-2025
    /// </summary>
    public class GuessEngine
    {
        private int secretNumber;
        private Random rng;

        // Input property (caller sets this)
        public int GuessInput { get; set; }

        // Last result message (caller reads this)
        public string LastResult { get; private set; }

        // Personal signature (read-only)
        public string Signature
        {
            get
            {
                return "VDT-GuessLib by VU DUC TU (VDT) - 2025";
            }
        }

        // Create a new engine; optionally seed for deterministic behavior (useful for tests)
        public GuessEngine() : this((int)DateTime.Now.Ticks)
        {
        }

        public GuessEngine(int seed)
        {
            // Use Random with seed so instance generates deterministic or pseudo-random depending on seed
            this.rng = new Random(seed);
            ResetSecret();
            this.LastResult = "Engine ready. " + Signature;
        }

        // Reset / start a new game (generate secret 1..100)
        public void ResetSecret()
        {
            // Generate 1..100 inclusive
            this.secretNumber = this.rng.Next(1, 101);
            this.LastResult = "New secret generated. " + Signature;
        }

        // Main guess method: uses internal GuessInput property and returns the result string
        public string Guess()
        {
            return this.Guess(this.GuessInput);
        }

        // Overload: accept guess as int and return string result
        public string Guess(int number)
        {
            // Validate range
            if (number < 1 || number > 100)
            {
                this.LastResult = "Ngoại lệ: số phải trong khoảng 1–100. " + Signature;
                return this.LastResult;
            }

            if (number == this.secretNumber)
            {
                this.LastResult = "Chính xác! Bạn đã đoán đúng số (" + this.secretNumber.ToString() + "). " + Signature;
                return this.LastResult;
            }
            else if (number < this.secretNumber)
            {
                this.LastResult = "Lớn hơn. " + Signature;
                return this.LastResult;
            }
            else
            {
                this.LastResult = "Nhỏ hơn. " + Signature;
                return this.LastResult;
            }
        }

        // Optional: expose how many tries hints (not tracking attempts to keep it stateless)
        // You can add attempt tracking if needed.
    }
}
