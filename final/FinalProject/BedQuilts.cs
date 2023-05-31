using System;

public class BedQuilts : Quilt
{
    private string _giftedTo;
    private int _giftedYear;

public BedQuilts(string name, string description, int yearCreated, int length,
    int width, Fabric fabricUsed, string giftedTo, int giftedYear) : 
    base (name, description, yearCreated, length, width, fabricUsed)
{
    _giftedTo = giftedTo;
    _giftedYear = giftedYear;

}

public string GetGiftedTo()
    {
        return _giftedTo;
    }

public void SetGiftedTo(string giftedTo)
    {
        _giftedTo = giftedTo;
    }

public int GetGiftedYear()
{
    return _giftedYear;
}

public void GetGiftedYear(int giftedYear)
{
    _giftedYear = giftedYear;
}

    public override string GetQuiltSummary()
    {
        return $"{_name} ({_description}), {_yearCreated}, {_length} in. x {_width} in., {_fabricUsed.ToSummary()}, {_giftedTo}, {_giftedYear}";
    }

    public override string GetQuiltFormat()
    {
        return $"Bed Quilt: {_name}|{_description}| {_yearCreated}| {_length}| {_width}| {_fabricUsed.ToFormat()}| {_giftedTo}| {_giftedYear}";
    }

}