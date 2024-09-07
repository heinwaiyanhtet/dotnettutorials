namespace MainProgam
{   
    class MyGenricClass<T>
    {
        private T GenericMemberVariable;

        public MyGenricClass(T value){

            GenericMemberVariable = value;

        }

        public T GenericMethod(T GenericParameter)
        {
            Console.WriteLine($"Parameter type: { typeof(T).ToString()}, Value: {GenericParameter}");
            Console.WriteLine($"Return type: {typeof(T).ToString()}, Value: {GenericMemberVariable}");
            return GenericMemberVariable;
        }

         public T GenericProperty { get; set; }
    }
}