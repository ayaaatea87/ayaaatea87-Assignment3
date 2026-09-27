
# Part E — Stack & Heap

## Diagram 1 — After line 1

line 1: `Order o1 = new Order { OrderId = 1, CustomerName = "Ali" };`

```text
STACK                    HEAP

┌─────────────┐          ┌─────────────────┐
│ o1          │          │ Order           │
│             │          │ OrderId = 1     │
│ address ────┼─────────>│ CustomerName=Ali│
└─────────────┘          │ IsPaid = false  │
                         └─────────────────┘
````

o1 store a refrences of order object in heap.

## Diagram 2 — After line 2

line 2: `Order o2 = o1;`

```text
STACK                    HEAP

┌─────────────┐
│ o1 ─────────┼───────┐
└─────────────┘       │
                      ▼
┌─────────────┐       ┌──────────────────┐
│ o2 ─────────┼──────>│ Order            │
└─────────────┘       │ OrderId = 1      │
                      │ CustomerName=Ali │
                      │ IsPaid = false   │
                      └──────────────────┘
```

o2, o1 store the same refrence to the order object in heap.

## Diagram 3 — After line 3

line 3: `o2.IsPaid = true;`

```text
STACK                    HEAP

┌─────────────┐
│ o1 ─────────┼───────┐
└─────────────┘       │
                      ▼
┌─────────────┐       ┌──────────────────┐
│ o2 ─────────┼──────>│ Order            │
└─────────────┘       │ OrderId = 1      │
                      │ CustomerName=Ali │
                      │ IsPaid = true    │
                      └──────────────────┘
```

IsPaid change its value as it is a field shared, and o1, o2 still point to the same object.

## What would be different with structs

`struct Point` is a value type.

When we assign one variable to another, the value is copied, not the reference.

`Point p2 = p1;`

p2 now stores the value that was in p1.

If we change p2, p1 is not affected.
 So if we use struct not class here :
1- o2 will copy the value that store in o1
2- when (IsPaid) changed using o2 >>> o2.IsPaid = true ;
3- the value of IsPaid that stored in o1 Dosen't change (still = false)

```
```
