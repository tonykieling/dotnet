namespace K {
  class A {
    string _name;

    public A(string name) {
      _name = name;
    }

    public string Name {
      get => _name;
      set => _name = value;
    }

    public string GetA() {
      return $"inside A, name is {_name}";
    }
  }
}