namespace veterinariaApi.Responces
{
    public class HttpResponseWrapper<T>
    {
        public T? Data { get; set; }
        public bool WasSucceeded { get; set; }

        public string? Message { get; set;}
    }
}
