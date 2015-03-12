# Ch. 3 -- Data Types

## Strongly Typed
* All ops are type checked by compiler for type compat.
* helps prevent erros and enhances reliability

## Dynamic type 
* dynamic keyword
* allows type checking to be deferred until runtime.

## Value Types
* holds an actual value
* basic low level data elements.
* simple types (e.g. bool, byte, char, decimal, double, float, int, long, sbyte)
* range and behavior strictly specified for these types.
* other value types: enums, structs, and nullable.

## Integers
* byte, sbyte, short, ushort, int, uint, long, ulong
* if unsigned, the top order bit can be used to hold value not just +/-
* twice the abs magnitude

## Floating point
* two kinds: float and double.  
* float: 32 bits and double 64 bits.
* double is most common b/c most of .NET math functions use double.

## Decimal
* monetary calculations
* 128 bits.  1 * 10^-28 to 7.9 * 10^28
* eliminates normal float point arith rounding errors.
* suffix with m

## Characters
* 16 bit unicode type
* unicode is a char set large enough to represent all chars found in all human langs
* Chinese uses large # of chars.  Can't be represented in only 8 bits
* char is unsigned 16 bit.  0 to 65,535.
* std 8 bit ASCII is subset of unicode.

## Bool
* no conversion b/w int and bool.  1 is not true 0 is not false.

## Literals
* 12 is int literal
* 12L is a long literal
* 12.25M is a decimal literal
* 0xFF is a hex literal
* @ is used to start string literal.  You can use newlines, tabs inside.

## Inplicitly typed variables
* var keyword
* must be initialized at declaration
* type is determined at compile time.  once determined, it is fixed.

## Scope rules
* variable can't have same name as variable in a higher level scope

## type conversion
* if types are compatible, they are automatically converted.
* if destination has range greater than source, widening conversion takes place
* long to double is widening.  double to long is not.  
* when cast is a narrowing conversion, info may be lost.  e.g. long -> int

## type promotion rules
* in expressions, you can convert types.  
* if one operand is decimal, the other is promoted to decimal.
* else if one is a double, the second is promoted to double.
* etc, etc...down the chain...float, ulong, long, uint, int.
* if a byte var is promoted to int inside expression, it is still an int outside the expression.
* when two bytes are multiplied, both are promoted to ints.  then they need to be cast back down to bytes.
* for unary ops, operands smaller than int are promoted to int.

## Reference Types
* holds a reference to the value.
