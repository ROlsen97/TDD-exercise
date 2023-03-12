namespace TDD_exercise
{
    public class StringUtility
    {
        public int CountOccurences(string stringToCheck, string stringToFind)
        {
            var stringAsCharArray = stringToCheck.ToCharArray();
            var stringToCheckForAsChar = stringToFind.ToCharArray()[0];
            var occaranceCount = 0;
            for(var characterIndex = 0; characterIndex< stringAsCharArray.Count(); characterIndex++) 
            {
                if (stringAsCharArray[characterIndex] == stringToCheckForAsChar)
                {
                    occaranceCount++;
                }
            }
            return occaranceCount;
        }
    }
}