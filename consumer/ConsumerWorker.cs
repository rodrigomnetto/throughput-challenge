using Confluent.Kafka;

public class ConsumerWorker : IHostedService
{
    private readonly IConsumer<Ignore, string> _consumer;

    public ConsumerWorker(IConsumer<Ignore, string> consumer)
    {
        _consumer = consumer;
    }
    
    public Task StartAsync(CancellationToken cancellationToken)
    {
        while (cancellationToken.IsCancellationRequested is false)
        {
            _consumer.Consume(cancellationToken);
            
            //bulk insert orders
            //check if orders already exists
            
            
        }
        
        
        
        
        throw new NotImplementedException();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}