# Helper library
## For console applications

---
## Including classes
* `Helper.Cons`
* `Helper.ListOps`
* `Helper.StringOps`

## To initialize 
  1) Open solution bar
  2) Right click on dependencies 
  3) Add project reference 
  4) Click `Browse` 
  5) Go to this path `Helper\bin\Debug\net7.0`
  6) Find `Helper.dll` and Add
---
## Helper.Cons class includes these methods
* `Print() and Print(object obj)`
* `SeperateLine(int length)`

## To use it 
  `using static Helper.Cons;`

## Examples
  * `Print("Hello World");` => _Hello World_
  * `Print($"This is {name});` => _This is Jhon_
  * `Print(5 + 2);` => _7_
  * `SeperateLine(30);` => ------------------------------
---
## Helper.ListOps class includes these methods
  * `ShowElements(IEnumerable list)`

## To use it 
  `using static Helper.ListOps;`

## Examples
  * `1. int[] nums = new int[] {1, 2, 3};`
  * `2. ShowElements(nums);` => 1, 2, 3
---
## Helper.StringOps class includes these methods
  * `Combine(params string[] paths);`
  * `Combine(string path1, string path2);` 4+ more

## To use it 
  `using static Helper.StringOps;`

## Examples
  * `1. string hello = "Hello ";`
  * `2. string world = "World";`
  * `3. Combine(hello, world);` => Hello World
