> **Language Notice**: 
> [View in Arabic (العربية)](README_AR.md) |

# List Capacity and Count Demo in C#

This C# program demonstrates how the `Count` and `Capacity` properties of a `List<int>` change dynamically as items are added and removed. It showcases the automatic resizing behavior of .NET's `List<T>` collection.

## Key Concepts Demonstrated
- **Count vs Capacity**: 
  - `Count` = Number of elements actually in the list
  - `Capacity` = Total allocated storage space
- Automatic capacity doubling when adding elements beyond current capacity
- Impact of `Remove()` and `RemoveRange()` operations
- Effect of `TrimExcess()` on reducing capacity

## How to Run
1. **Prerequisites**: Install [.NET SDK](https://dotnet.microsoft.com/download) (version 5.0+ recommended)
2. Clone the repository:
   ```bash
   git clone https://github.com/MohmdAliMohmd/UnderstandingCountCapacityList.git
   ```
3. Run the program:
   ```bash
   cd your-repo-name
   dotnet run
   ```

## Expected Output
```
After Creation             Count    :  0, Capacity :  0
After Adding 1             Count    :  1, Capacity :  4
After Adding 2             Count    :  2, Capacity :  4
After Adding 3             Count    :  3, Capacity :  4
After Adding 4             Count    :  4, Capacity :  4
After Adding 5             Count    :  5, Capacity :  8
After Adding 6,7,8         Count    :  8, Capacity :  8
After Adding 9             Count    :  9, Capacity : 16
After Removing 1           Count    :  8, Capacity : 16
After Removing 3 items from index 2 Count    :  5, Capacity : 16
After TrimExcess           Count    :  5, Capacity :  5
```

## Behavior Explained
1. **Initialization**: Empty list starts with 0 capacity
2. **Adding items**:
   - Capacity doubles when exceeded (4 → 8 → 16)
   - Default initial capacity after first addition: 4
3. **Removing items**:
   - `Remove()` and `RemoveRange()` reduce Count but not Capacity
   - Capacity remains unchanged until explicitly trimmed
4. **TrimExcess()**:
   - Reduces capacity to match current count
   - Only affects capacity if >90% of space is unused

## Understanding the Output
- Notice how capacity grows exponentially (0 → 4 → 8 → 16) to optimize performance
- Removing elements doesn't automatically shrink capacity
- `TrimExcess()` recovers unused memory when significant space is wasted

This demo illustrates the memory/performance tradeoffs in .NET's List implementation.
