namespace K {
  class B : A {
    string _lastName;

    public B(string name, string lastName)
      : base(name) {
      _lastName = lastName;
    }

    string LastName {
      get => _lastName;
      set => _lastName = value;
    }

    public string GetB() {
      return $"inside GetB: {Name} {LastName}";
    }

  }
}