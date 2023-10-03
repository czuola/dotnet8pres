var fruit = "Banana";
var letters = new[]{'n', 'a'};


System.Buffers.SearchValues<char> searchValues = System.Buffers.SearchValues.Create(letters);
fruit.IndexOfAny(letters);