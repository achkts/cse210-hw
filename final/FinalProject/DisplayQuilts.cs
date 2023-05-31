using System;

public class DisplayQuilts : Quilt
{
    private string _taughtBy;
    private string _taughtAt;
   
   public DisplayQuilts(string name, string description, int yearCreated, 
    int length, int width, Fabric fabricUsed, string taughtBy, string taughtAt) :
    base(name, description, yearCreated, length, width, fabricUsed)
    {
        _taughtBy = taughtBy;
        _taughtAt = taughtAt;
    }

    public override string GetQuiltSummary()
    {
        return $"{_name} ({_description}), {_yearCreated}, {_length} in. x {_width} in., {_fabricUsed.ToSummary()}, {_taughtBy}, {_taughtAt}";
    }

    public override string GetQuiltFormat()
    {
        return $"Display Quilt: {_name}|{_description}| {_yearCreated}| {_length}| {_width}| {_fabricUsed.ToFormat()}| {_taughtBy}| {_taughtAt}";
    }

}