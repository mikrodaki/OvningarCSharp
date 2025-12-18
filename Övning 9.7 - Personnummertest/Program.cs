namespace Övning_9._7___Personnummertest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				bool inputOk = false;
				string userInput = "";
				int totalSum = 0;
				bool personalNumberOk;
				int controlDigit;

				// Loop until the user submitted a ten digit number
				while (!inputOk)
				{
					Console.Clear();
					Console.WriteLine("PERSONNUMMERTEST\n--------------");
					Console.Write("Ange ett tiosiffrigt personnummer: ");
					userInput = Console.ReadLine();
					inputOk = checkUserInput();
				}

				// The last digit in the person number
				controlDigit = int.Parse(userInput[9].ToString());

				/* Loop through the 9 first digits of the person number and do calculations to get the
				 * total sum
				 */
				for (int i = 0; i < 9; i++)
				{
					// Set sum to the value of the digit in the current position
					var sum = int.Parse(userInput[i].ToString());

					// If the positon of the digit is even, multiply sum by two
					if (i % 2 == 0)
						sum *= 2;

					/*
					 * If the sum of the multiplication is greater than ten we must sum the
					 * digits of that number
					 * */
					if (sum >= 10)
					{
						int tensDigit = sum / 10;
						int onesDigit = sum % 10;
						sum = tensDigit + onesDigit;
					}

					// Add the sum of the calculation for the current lap to the total sum
					totalSum += sum;
				}

				// If the total sum is dividable by 10 and the last number is 0 the number is ok
				if (totalSum % 10 == 0 && controlDigit == 0)
				{
					personalNumberOk = true;
				}
				else
				{
					int number = 1;

					/* Loop until we find a number that can be added to the total sum to make 
					 * the new sum diviable by 10
					*/
					while ((totalSum + number) % 10 != 0)
					{
						number++;
					}

					// If the number that we found is equal to the contol digit the person number is
					// valid, otherwise not. 
					if (controlDigit == number)
						personalNumberOk = true;
					else
						personalNumberOk = false;
				}

				if (personalNumberOk)
					Console.WriteLine($"Personnumret {userInput} är ett giltigt personnummer");
				else
					Console.WriteLine($"Personnumret {userInput} är inte ett giltigt personnummer");

				Console.ReadKey();

				// Checks if the user has provided a ten digit number or not
				bool checkUserInput()
				{
					if (userInput.Length != 10)
						return false;
					else
						for (int i = 0; i < userInput.Length; i++)
						{
							if (!char.IsDigit(userInput[i]))
								return false;
						}
					return true;
				}
			}

		}
	}
}
