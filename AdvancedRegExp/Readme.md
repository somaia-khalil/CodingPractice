## The Advanced Regular Expression Challenge

You are given a collection of strings containing email addresses and phone numbers. Your task is to implement a class `DataExtractor` that uses regular expressions to extract specific data from these strings.

### Class: DataExtractor

#### Properties:

1. `DataCollection` (List<string>): A private list of strings containing email addresses and phone numbers.

#### Methods:

1. `ExtractEmails`: A public method that extracts all valid email addresses from the data collection and returns them as a list of strings. An email address is considered valid if it follows the standard email format (e.g., `username@example.com`) and does not contain any invalid characters.

2. `ExtractPhoneNumbers`: A public method that extracts all valid phone numbers from the data collection and returns them as a list of strings. A phone number is considered valid if it matches the following formats:
   - (XXX) XXX-XXXX
   - XXX-XXX-XXXX
   - XXX XXX XXXX

3. `ExtractEmailDomains`: A public method that extracts all unique email domains from the data collection and returns them as a list of strings. For example, given the emails `user1@example.com`, `user2@example.com`, and `user3@domain.com`, the method should return `["example.com", "domain.com"]`.

4. `ExtractPhoneAreaCodes`: A public method that extracts all unique phone area codes from the data collection and returns them as a list of strings. For example, given the phone numbers `(123) 456-7890`, `555-987-6543`, and `789 456 1234`, the method should return `["123", "555", "789"]`.

### Constraints:

- The data collection can contain up to 10^5 strings, each with a maximum length of 200 characters.
- Each string may contain multiple email addresses and phone numbers.

### Example

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> dataCollection = new List<string>
        {
            "Emails: user1@example.com, user2@example.com, user3@domain.com. Phone numbers: (123) 456-7890, 555-987-6543",
            "Contact us at contact@example.com or call 789 456 1234 for assistance.",
            // ... (many more strings)
        };

        DataExtractor extractor = new DataExtractor(dataCollection);

        List<string> emails = extractor.ExtractEmails();
        Console.WriteLine("Extracted Emails: ");
        foreach (string email in emails)
        {
            Console.WriteLine(email);
        }

        List<string> phoneNumbers = extractor.ExtractPhoneNumbers();
        Console.WriteLine("\nExtracted Phone Numbers: ");
        foreach (string phoneNumber in phoneNumbers)
        {
            Console.WriteLine(phoneNumber);
        }

        List<string> emailDomains = extractor.ExtractEmailDomains();
        Console.WriteLine("\nExtracted Email Domains: ");
        foreach (string domain in emailDomains)
        {
            Console.WriteLine(domain);
        }

        List<string> phoneAreaCodes = extractor.ExtractPhoneAreaCodes();
        Console.WriteLine("\nExtracted Phone Area Codes: ");
        foreach (string areaCode in phoneAreaCodes)
        {
            Console.WriteLine(areaCode);
        }
    }
}
