#### Aplicación ThrowApp

### Problema:
cuando se lanza una excepción desde un método asincrónico esta es wrapped(envuelta) en una Excepción del tipo AggregateException
que contiene todas las excepciones que fueron lanzadas en la tarea, las mismas pueden obtenerse recorriendo la propiedad InnerExceptions.

### Fuentes:
https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/exception-handling-task-parallel-library
https://docs.microsoft.com/en-us/dotnet/api/system.aggregateexception?view=netframework-4.8
