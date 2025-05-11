namespace Problems;

public class ValidParentheses
{
    private readonly Dictionary<char, char> _matches = new()
    {
        { '(', ')' },
        { '{', '}' },
        { '[', ']' },
    };
    
    public bool IsValid(string s)
    {
        var bracketsArray = s.ToCharArray();
        var openBracketsStack = new Stack<char>();
        foreach (var bracket in bracketsArray)
        {
            if (_matches.ContainsKey(bracket))
            {
                openBracketsStack.Push(bracket);
                continue;
            }

            if (openBracketsStack.Count == 0)
            {
                return false;
            }
            
            if (_matches[openBracketsStack.Peek()] != bracket) return false;
            
            openBracketsStack.Pop();
        }

        return openBracketsStack.Count == 0;
    }
}