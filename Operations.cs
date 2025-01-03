public class Operation
{
    // 덧셈 함수
    public int add(int a, int b)
    {
        return a + b;
    }

    // 뺄셈 함수
    public int subtract(int a, int b)
    {
        return a - b;
    }

    // 곱셈 함수
    public int multiply(int a, int b)
    {
        return a * b;
    }

    // 나눗셈 함수
    public int divide(int a, int b)
    {
        return a / b;
    }

    // 거듭제곱 함수
    public int exponentiate(int x, int n)
    {
        int result = 1;

        for(int i = 0; i < n; i++)
        {
            result *= x;
        }

        return result;
    }
}