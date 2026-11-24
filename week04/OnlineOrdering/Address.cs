using System;

public class Address
{
    private string _streetAddress = "";
    private string _city = "";
    private string _stateProvince = "";
    private string _country = "";


    public Address()
    {

    }
    public Address(string address, string city, string state, string country)
    {
        _streetAddress = address;
        _city = city;
        _stateProvince = state;
        _country = country;
    }

    public string GetCountry()
    {
        if (_country == "USA")
        {
            _country = "USA";
        }
        else
        {
            _country = "other";
        }
        return _country;
    }
    public string GetAddress()
    {
        string orderAddress = ($"{_streetAddress}\n{_city}\n{_stateProvince}\n{_country}");
        return orderAddress;
    }

}