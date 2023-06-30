
// Solution to the Palindrome Checker challenge

function isPalindrome(str) {
  // Remove all non-alphanumeric characters and convert to lowercase
  const cleanedStr = str.replace(/[^a-zA-Z0-9]/g, '').toLowerCase();

  // Compare the cleaned string with its reverse
  return cleanedStr === cleanedStr.split('').reverse().join('');
}

module.exports = isPalindrome;
