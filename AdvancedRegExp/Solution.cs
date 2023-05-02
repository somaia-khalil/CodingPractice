// Solution to The Advanced Regular Expression Challenge

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class DataExtractor
{
    private List<string> DataCollection;

    public DataExtractor(List<string> dataCollection)
    {
        DataCollection = dataCollection;
    }

    public List<string> ExtractEmails()
    {
        List<string> emails = new List<string>();
        foreach (string data in DataCollection)
        {
            MatchCollection matches = Regex.Matches(data, @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b");
            foreach (Match match in matches)
            {
                emails.Add(match.Value);
            }
        }
        return emails;
    }

    public List<string> ExtractPhoneNumbers()
    {
        List<string> phoneNumbers = new List<string>();
        foreach (string data in DataCollection)
        {
            MatchCollection matches = Regex.Matches(data, @"\b(\(\d{3}\)\s*|\d{3}-)\d{3}-\d{4}\b|\b\d{3}\s+\d{3}\s+\d{4}\b");
            foreach (Match match in matches)
            {
                phoneNumbers.Add(match.Value);
            }
        }
        return phoneNumbers;
    }

    public List<string> ExtractEmailDomains()
    {
        HashSet<string> uniqueDomains = new HashSet<string>();
        foreach (string data in DataCollection)
        {
            MatchCollection matches = Regex.Matches(data, @"\b[A-Za-z0-9._%+-]+@([A-Za-z0-9.-]+\.[A-Z|a-z]{2,})\b");
            foreach (Match match in matches)
            {
                uniqueDomains.Add(match.Groups[1].Value);
            }
        }
        return new List<string>(uniqueDomains);
    }

    public List<string> ExtractPhoneAreaCodes()
    {
        HashSet<string> uniqueAreaCodes = new HashSet<string>();
        foreach (string data in DataCollection)
        {
            MatchCollection matches = Regex.Matches(data, @"\b(\(\d{3}\)\s*|\d{3}-)\d{3}-\d{4}\b|\b\d{3}\s+\d{3}\s+\d{4}\b");
            foreach (Match match in matches)
            {
                string phoneNumber = match.Value;
                string areaCode = new string(phoneNumber.Where(char.IsDigit).Take(3).ToArray());
                uniqueAreaCodes.Add(areaCode);
            }
        }
        return new List<string>(uniqueAreaCodes);
    }
}
