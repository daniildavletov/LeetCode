namespace Problems.Concurrency;

public class PrintInOrder
{
}

public class Foo {

    public Foo() {
        
    }

    private AutoResetEvent _firstPrintedEvent = new AutoResetEvent(false);
    private AutoResetEvent _secondPrintedEvent = new AutoResetEvent(false);
    
    public void First(Action printFirst) {
        
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        _firstPrintedEvent.Set();
    }

    public void Second(Action printSecond) {
        
        // printSecond() outputs "second". Do not change or remove this line.
        _firstPrintedEvent.WaitOne();
        printSecond();
        _secondPrintedEvent.Set();
    }

    public void Third(Action printThird) {
        
        // printThird() outputs "third". Do not change or remove this line.
        _secondPrintedEvent.WaitOne();
        printThird();
    }
}