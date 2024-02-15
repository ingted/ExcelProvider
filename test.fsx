//#r @"E:\ExcelProvider\src\ExcelProvider.Runtime\bin\Debug\netstandard2.0\ExcelProvider.Runtime.dll"
#r @"G:\coldfar_py\ExcelProvider\src\ExcelProvider.Runtime\bin\Release\netstandard2.0\ExcelProvider.Runtime.dll"
open FSharp.Interop.Excel

[<Literal>]
//let a = @"S:\Misc\MiscScripts\Excel\FileFormat\BalanceSheet\匯入檔\202312_群益.xls"
let a = @"G:\BalanceSheet\匯入檔\202312_群益.xls"

type BalanceSheetFCMTyp = ExcelFile<a, SheetName="月計表", HasHeaders=false>


BalanceSheetFCMTyp(a, @"月計表").Data |> Seq.toArray

//--optimize --multiemit+  --langversion:preview