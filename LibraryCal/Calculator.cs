using System;

namespace LibraryCal
{
    public class Calculator
    {
        private Operator _operation = null;
        private ILogger _logger = null;
        private string _num1 = "";
        private string _num2 = "";
        private string _oprSign = "";
        public Calculator(string x, string y)
        {
            _num1 = x;
            _num2 = y;
            SetOperator("+");
            _logger = null;
        }
        public Calculator(string opr,string x, string y)
        {
            _num1 = x;
            _num2 = y;
            SetOperator(opr);
            _logger = null;
        }
        public Calculator(string opr, string x, string y,ILogger formatLog)
        {
            _num1 = x;
            _num2 = y;
            SetOperator(opr);
            SetLogger(formatLog);
        }


        public void SetLogger(ILogger formatLog)
        {
            _logger = formatLog;
        }
        public void SetOperator(string opr)
        {
            switch (opr)
            {
                case "+":
                case "-add": _operation = new AddOpr(); _oprSign = "+"; break;
                case "-":
                case "-minus": _operation = new MinusOpr(); _oprSign = "-"; break;
                case "*":
                case "-multiply": _operation = new MultiplyOpr(); _oprSign = "*"; break;
                case "/":
                case "-divide": _operation = new DivideOpr(); _oprSign = "/"; break;
            }
        }

        public float Cal()
        {
            float ans = _operation.Cal(float.Parse(_num1), float.Parse(_num2));
            if(_logger!=null)
                _logger.Log(_num1 + _oprSign + _num2 + "=" + ans);
            return ans;
        }
    }
    interface Operator
    {
        float Cal(float x, float y);
    }
    sealed class AddOpr : Operator
    {
        public float Cal(float x, float y)
        {
            return x + y;
        }
    }
    sealed class MinusOpr : Operator
    {
        public float Cal(float x, float y)
        {
            return x - y;
        }
    }
    sealed class MultiplyOpr : Operator
    {
        public float Cal(float x, float y)
        {
            return x * y;
        }
    }
    sealed class DivideOpr : Operator
    {
        public float Cal(float x, float y)
        {
            return x / y;
        }
    }
}
