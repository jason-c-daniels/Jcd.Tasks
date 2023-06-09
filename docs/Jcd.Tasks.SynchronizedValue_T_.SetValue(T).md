### [Jcd.Tasks](Jcd.Tasks.md 'Jcd.Tasks').[SynchronizedValue&lt;T&gt;](Jcd.Tasks.SynchronizedValue_T_.md 'Jcd.Tasks.SynchronizedValue<T>')

## SynchronizedValue<T>.SetValue(T) Method

Sets the current value to the provided value.

```csharp
public T SetValue(T value);
```
#### Parameters

<a name='Jcd.Tasks.SynchronizedValue_T_.SetValue(T).value'></a>

`value` [T](Jcd.Tasks.SynchronizedValue_T_.md#Jcd.Tasks.SynchronizedValue_T_.T 'Jcd.Tasks.SynchronizedValue<T>.T')

The provided value.

#### Returns
[T](Jcd.Tasks.SynchronizedValue_T_.md#Jcd.Tasks.SynchronizedValue_T_.T 'Jcd.Tasks.SynchronizedValue<T>.T')  
The provided value.

### Example
  
```csharp  
var sv = new SynchronizedValue<int>();  
  
// set the value to 10.  
setValue = sv.SetValue(10);  
  
// set the value to 20.  
setValue = sv.SetValue(20);  
```