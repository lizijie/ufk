//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Table/TestTable.proto
namespace Table.TestTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Address2")]
  public partial class Address2 : global::ProtoBuf.IExtensible
  {
    public Address2() {}
    
    private string _Line1 = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Line1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Line1
    {
      get { return _Line1; }
      set { _Line1 = value; }
    }
    private string _Line2 = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Line2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Line2
    {
      get { return _Line2; }
      set { _Line2 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Person2")]
  public partial class Person2 : global::ProtoBuf.IExtensible
  {
    public Person2() {}
    
    private int _Id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Id
    {
      get { return _Id; }
      set { _Id = value; }
    }
    private string _Name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private Address2 _Address = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Address", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Address2 Address
    {
      get { return _Address; }
      set { _Address = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}