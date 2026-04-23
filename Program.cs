using System;

namespace CyberSecurityChatbot
{
    class Chatbot
    {
        public virtual void Respond()
        {
            Console.WriteLine("I can help you stay safe online.");
        }
    }

    // Greeting
    class GreetingBot : Chatbot
    {
        public override void Respond()
        {
            Console.WriteLine("Hello 👋 Welcome to the Cybersecurity Awareness Chatbot!");
            Console.WriteLine("You can type questions OR choose a topic number.");
        }
    }

    class PasswordBot : Chatbot
    {
        public override void Respond()
        {
            Console.WriteLine("🔐 Strong Password Tips:");
            Console.WriteLine("- Use at least 12 characters");
            Console.WriteLine("- Mix uppercase, lowercase, numbers, symbols");
            Console.WriteLine("- Never reuse passwords");
            Console.WriteLine("- Consider a password manager");
        }
    }

    class PhishingBot : Chatbot
    {
        public override void Respond()
        {
            Console.WriteLine("🎣 Phishing Awareness:");
            Console.WriteLine("- Do not click suspicious links");
            Console.WriteLine("- Check sender email carefully");
            Console.WriteLine("- Banks never ask for passwords via email");
            Console.WriteLine("- Verify requests directly");
        }
    }

    class MalwareBot : Chatbot
    {
        public override void Respond()
        {
            Console.WriteLine("🛡️ Malware Protection:");
            Console.WriteLine("- Install antivirus software");
            Console.WriteLine("- Keep software updated");
            Console.WriteLine("- Avoid pirated downloads");
            Console.WriteLine("- Scan USB drives before use");
        }
    }

    class PrivacyBot : Chatbot
    {
        public override void Respond()
        {
            Console.WriteLine("🔒 Online Privacy Tips:");
            Console.WriteLine("- Limit personal info on social media");
            Console.WriteLine("- Review app permissions");
            Console.WriteLine("- Use privacy settings");
            Console.WriteLine("- Avoid public Wi-Fi for sensitive tasks");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ===== ASCII LOGO =====
            Console.WriteLine("===============================================");
            Console.WriteLine("   ██████╗ ██╗   ██╗██████╗ ███████╗██████╗ ");
            Console.WriteLine("  ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗");
            Console.WriteLine("  ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝");
            Console.WriteLine("  ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗");
            Console.WriteLine("  ╚██████╗   ██║   ██████╔╝███████╗██║  ██║");
            Console.WriteLine("   ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝");
            Console.WriteLine("        CYBERSECURITY CHATBOT 🤖          ");
            Console.WriteLine("=================================================");

            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.Write("Name cannot be empty. Please enter your name: ");
                userName = Console.ReadLine();
            }

            Console.WriteLine($"\nWelcome, {userName}! 👋");

            Console.WriteLine($"{userName}, how are you today?");
            string mood = Console.ReadLine();

            if (mood.Contains("good") || mood.Contains("fine") || mood.Contains("great"))
            {
                Console.WriteLine($"That's great to hear, {userName}! 😊 Let's get started.\n");
            }
            else if (mood.Contains("bad") || mood.Contains("tired") || mood.Contains("sad"))
            {
                Console.WriteLine($"Sorry to hear that, {userName}. Hopefully I can cheer you up! 💙\n");
            }
            else
            {
                Console.WriteLine($"Thanks for sharing, {userName}! Let's get started.\n");
            }

            Chatbot bot;

            while (true)
            {
                Console.WriteLine($"\n{userName}, choose a topic or ask a question:");
                Console.WriteLine("1 - Passwords");
                Console.WriteLine("2 - Phishing");
                Console.WriteLine("3 - Privacy");
                Console.WriteLine("4 - Malware");
                Console.WriteLine();
                Console.WriteLine("Type 'exit' to quit");
                Console.WriteLine();
                Console.Write("Your input: ");
                Console.WriteLine();

                string input = Console.ReadLine()?.ToLower() ?? "";

                if (input == "")
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                    continue;
                }

                if (input == "exit")
                {
                    Console.WriteLine($"Goodbye {userName} 👋 Stay safe online!");
                    return;
                }

                // MENU
                if (input.Contains("1") || input.Contains("password"))
                {
                    bot = new PasswordBot();
                    bot.Respond();
                    continue;
                }
                else if (input.Contains("2") || input.Contains("phishing"))
                {
                    bot = new PhishingBot();
                    bot.Respond();
                    continue;
                }
                else if (input.Contains("3") || input.Contains("privacy"))
                {
                    bot = new PrivacyBot();
                    bot.Respond();
                    continue;
                }
                else if (input.Contains("4") || input.Contains("malware"))
                {
                    bot = new MalwareBot();
                    bot.Respond();
                    continue;
                }
                // Conversational Responses
                switch (input)
                {
                    case "how are you":
                        Console.WriteLine("I'm a bot, so I don't have feelings, but I'm happy to assist! 😊");
                        break;

                    case "whats your name":
                    case "what's your name":
                        Console.WriteLine("I'm your CyberSecurity Awareness Bot 🤖");
                        break;

                    case "who created you":
                        Console.WriteLine("I was built by IT students to promote cybersecurity awareness.");
                        break;

                    case "tell me a joke":
                        Console.WriteLine("Why did the computer go to the doctor? Because it had a virus 😄");
                        break;

                    case "whats your purpose":
                    case "what's your purpose":
                        Console.WriteLine("My purpose is to educate users about cybersecurity topics.");
                        break;

                    default:
                        Console.WriteLine("Sorry, I didn't understand that. Try a topic number or question.");
                        break;
                }
            }
        }
    }
}