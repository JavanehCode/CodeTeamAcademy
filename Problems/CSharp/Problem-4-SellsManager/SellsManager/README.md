# SellsManager

Modify `SellsManager` project in a way that two follwoing conditions are met:
- Solution compiles without error.
- All tests are passed.

In this problem you read data from CSV file and calculate some information from raw data.

Items to calcualte from sells records:

- Most sold ProductId by quantity
- Total price paid for all sells
- Cheapest sold ProductId by average price (take quantity into account)
- Product Id with most number of consecutive quantities sold
- Product Id which its sells price has increased continuesly (if multiple results, output only the largest product id)

Sample file content:

```
RecordNumber | ProductId  | Price | Quantity
1            | 10003      | 20000 | 40
2            | 10005      | 800   | 100
3            | 10003      | 5600  | 20
4            | 10002      | 6300  | 8000
5            | 10008      | 420   | 700
```
