namespace Övning_9._7___Personnummertest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				string userInput = "";
				int totalSum = 0;
				bool personalNumberOk;
				int controlDigit;

				// Loop until the user submitted a ten digit number
				while (true)
				{
					Console.Clear();
					Console.WriteLine("PERSONNUMMERTEST\n--------------");
					Console.Write("Ange ett tiosiffrigt personnummer: ");
					userInput = Console.ReadLine();

					if (checkUserInput())
						break;

					Console.WriteLine("Ogiltigt inmatning. Försök igen.");
					Console.ReadKey();
				}


				// The last (number 10) digit in the person number is the control digit
				controlDigit = int.Parse(userInput[9].ToString());

				/* Loop through the 9 first digits of the person number and do calculations to get the
				 * total sum
				 */

				// Multiply every other number by two
				bool multiplyByTwo = true;

				// Loop from the right and skip the control digit
				for (int i = userInput.Length - 2; i >= 0; i--)
				{
					// Set sum to the value of the digit in the current position
					var sum = int.Parse(userInput[i].ToString());

					if (multiplyByTwo)
						sum *= 2;

					/*
					 * If the sum of the multiplication is greater than ten (or equal than ten) we must sum the
					 * digits of that number
					 * */
					if (sum > 9)
					{
						int tensDigit = sum / 10;
						int onesDigit = sum % 10;
						sum = tensDigit + onesDigit;
					}

					// Add the sum of the calculation for the current lap to the total sum
					totalSum += sum;

					multiplyByTwo = !multiplyByTwo;
				}


				/* Loop until we find a number that can be added to the total sum to make 
				 * the new sum diviable by 10
				*/
				int number = 0;

				while ((totalSum + number) % 10 != 0)
				{
					number++;
				}

				/* Matematisk version av ovanstående
				 * 
				 * int number = (10 - (totalSum % 10)) % 10;
				 *	
				 */

				// If the number that we found is equal to the contol digit the person number is
				// valid, otherwise not. 
				personalNumberOk = controlDigit == number;

				Console.WriteLine(
					personalNumberOk
						? $"Personnumret {userInput} är ett giltigt personnummer"
						: $"Personnumret {userInput} är INTE ett giltigt personnummer"
				);

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
