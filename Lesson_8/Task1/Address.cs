using System;

class Address
{
	private string index; // ������
	private string country; // �����
	private string city; // ���� 
	private string street; // ������
	private string house; // ����� �������
	private string apartment; // ����� ��������

	public string Index
	{
		get { return index; }
		set { index = value; }
	}

	public string Country
	{
		get { return country; }
		set { country = value; }
	}

	public string City
	{
		get { return city; }
		set { city = value; }
	}

	public string Street
	{
		get { return street; }
		set { street = value; }
	}

	public string House
	{
		get { return house; }
		set { house = value; }
	}

	public string Apartment
	{
		get { return apartment; }
		set { apartment = value; }
	}

	public void DisplayAddress()
	{
		Console.OutputEncoding = System.Text.Encoding.Unicode;
		Console.ForegroundColor = ConsoleColor.Blue; // ������������� ����
		Console.WriteLine($"������: {Index}");
		Console.WriteLine($"�����: {Country}");
		Console.WriteLine($"̳���: {City}");
		Console.WriteLine($"������: {Street}");
		Console.WriteLine($"����� �������: {House}");
		Console.WriteLine($"����� ��������: {Apartment}");
	}
}