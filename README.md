# Exmple
```
decimal d = 0.1314M;
d.ValidDecimal(precision: 2);

output: 0.13;

decimal d = 578.1314M;
d.ValidDecimal(precision: 5);

output: 5.7813e+002;

decimal d = 578.13M;
d.ValidDecimal(precision: 2);

output: 578;
```