namespace PF2023.Shared.Wrapper;

public class Result 
{
    
    public Result()
    {
        
    }
    public Result(bool succeeded, List<string> message= default!)
    {
        this.Succeeded = succeeded;
        this.Message = message;
    }

    public bool Succeeded {get; set;}

    public List<string> Message { get; set; }

    public static Result Fail()
    {
        return new Result(false);
    }

        public static Result Fail(string message)
    {
        return new Result(false, new List<string>(){ message});
    }

     public static Result Fail(List<string> message)
    {
        return new Result(false, message);
    }

        public static Result Sucess(string message)
    {
        return new Result(true, new List<string>(){ message});
    }

         public static Result Sucess(List<string> message)
    {
        return new Result(true, message);
    }

}

public class Result<T>:Result
{
public T Data { get; set; } = default!;

public new static Result<T> Fail()
{
    return new Result<T> (){Succeeded = false, Message = new List<string>(){"❌"}};
}

public new static Result<T> Fail(string Message)
{
    return new Result<T> (){Succeeded = false, Message = new List<string>(){Message}};
}

public new static Result<T> Fail(List<string> message)
{
    return new Result<T> (){Succeeded = false, Message = message};
}

public Result<T> Success(T data)
{
    return new Result<T> (){
        Succeeded = true, 
        Message = new List<string>(){"🆗"},
        Data = data
        };
}

public Result<T> Success(T data, string message)
{
    return new Result<T> (){
        Succeeded = true, 
        Message = new List<string>(){message},
        Data = data
        };
}

public Result<T> Success(T data, List<string> message)
{
    return new Result<T> (){
        Succeeded = true, 
        Message = message,
        Data = data
        };
}

}
