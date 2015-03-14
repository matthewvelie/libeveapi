# Introduction #

The way eve determines what roles you have is by using a bitmask.  To figure out what roles you have use the table below along with the bitmask provided to you by the eve api or the IGB.


# Details #

The corprole is a bitmask, you can perform a logical and with the following values and it will result in that same value if the bit is set or in 0 if the bit is clear.

| Corprole | Number | Bit  |
|:---------|:-------|:-----|
| Director | 1 |  |
| Personnel Manager | 128 | 7 |
| Accountant | 256 | 8 |
| Security Officer | 512 | 9 |
| Factory Manager | 1024 | 10 |
| Station Manager | 2048 | 11 |
| Auditor | 4096 | 12 |
| Hangar Can Take Division 1 | 8192 | 13 |
| Hangar Can Take Division 2 | 16384 | 14 |
| Hangar Can Take Division 3 | 32768 | 15 |
| Hangar Can Take Division 4 | 65536 | 16 |
| Hangar Can Take Division 5 | 131072 | 17 |
| Hangar Can Take Division 6 | 262144 | 18 |
| Hangar Can Take Division 7 | 524288 | 19 |
| Hangar Can Query Division 1 | 1048576 | 20 |
| Hangar Can Query Division 2 | 2097152 | 21 |
| Hangar Can Query Division 3 | 4194304 | 22 |
| Hangar Can Query Division 4 | 8388608 | 23 |
| Hangar Can Query Division 5 | 16777216 | 24 |
| Hangar Can Query Division 6 | 33554432 | 25 |
| Hangar Can Query Division 7 | 67108864 | 26 |
| Account Can Take Division 1 | 134217728 | 27 |
| Account Can Take Division 2 | 268435456 | 28 |
| Account Can Take Division 3 | 536870912 | 29 |
| Account Can Take Division 4 | 1073741824 | 30 |
| Account Can Take Division 5 | 2147483648 | 31 |
| Account Can Take Division 6 | 4294967296 | 32 |
| Account Can Take Division 7 | 8589934592 | 33 |
| Account Can Query Division 1	| 17179869184 | 34 |
| Account Can Query Division 2	| 34359738368 | 35 |
| Account Can Query Division 3	| 68719476736 | 36 |
| Account Can Query Division 4	| 137438953472 | 37 |
| Account Can Query Division 5	| 274877906944 | 38 |
| Account Can Query Division 6 | 549755813888 | 39 |
| Account Can Query Division 7 | 1099511627776 | 40 |
| Equipment Config | 2199023255552 | 41 |
| Container Can Take Division 1 | 4398046511104 | 42 |
| Container Can Take Division 2 | 8796093022208 | 43 |
| Container Can Take Division 3 | 17592186044416 | 44 |
| Container Can Take Division 4 | 35184372088832 | 45 |
| Container Can Take Division 5 | 70368744177664 | 46 |
| Container Can Take Division 6 | 140737488355328 | 47 |
| Container Can Take Division 7 | 281474976710656 | 48 |
| Can Rent Office | 562949953421312 | 49 |
| Can Rent Factory Slot | 1125899906842624 | 50 |
| Can Rent Research Slot | 2251799813685248 | 51 |
| Junior Accountant | 4503599627370496 | 52 |
| Starbase Config | 9007199254740992 | 53 |
| Trader | 18014398509481984 | 54 |