## Summary
AdjustStringProperties is a .NET library which find all String Properties in an Object (Model,Dto,Entity) that have Setter and Adjust them.
this packge Built in .NetStandard 2.0 

## How To Install
#### Install With Package Manager Console
- Install-Package AdjustStringProperties

#### Install With NuGet Package Manager
![](https://github.com/ARFarokhi/AdjustStringProperties/blob/master/AdjustStringProperty/AdjustStringProperty/Img/NuGet.png)

## How To Use
First Let's Create Person Class:
```
 public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{Name} {LastName}";
        public string Description { get; set; }
    }
```    
Then Create Person Object:
```
var person = new Person()
            {
                Name = "John",
                LastName = "Smith",
                Description = "John Smith Description"
            };
```
Now We Can Use Package Like This:
```
 person.AdjustString();
``` 
### Let's See How AdjustStringProperties Package Can Help:

1-Trim String Peoperties

if User Input Data Is Like Bellow 
```
var person = new Person()
            {
                Name = "      John      ",
                LastName = "   Smith ",
                Description = "John Smith Description"
            };
```
As you Can See Bellow:

<img src="https://github.com/ARFarokhi/AdjustStringProperties/blob/master/AdjustStringProperty/AdjustStringProperty/Img/BeforeTrim.png" width="400px"/>

After Use of Package It Will Be Like Bellow:

<img src="https://github.com/ARFarokhi/AdjustStringProperties/blob/master/AdjustStringProperty/AdjustStringProperty/Img/AfterTrim.png" width="400px"/>

2-Replace Multiple Spaces With Single

if User Input Contains More Than 1 Space Between Words together ,Spaces Will Replace Will 1 Space .
look at "Description" property Bellow:
```
var person = new Person()
            {
                Name = "John",
                LastName = "Smith",
                Description = "John        Smith        Description"
            };
``` 

<img src="https://github.com/ARFarokhi/AdjustStringProperties/blob/master/AdjustStringProperty/AdjustStringProperty/Img/BeforeReplace.png" width="400px"/>

After Use of Package It Will Be Like Bellow:

<img src="https://github.com/ARFarokhi/AdjustStringProperties/blob/master/AdjustStringProperty/AdjustStringProperty/Img/AfterReplace.png" width="400px"/>

#### Note:
more features are in Progress and will be add to Package



