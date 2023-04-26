# ISA-ProjectSORA
An Information Security and Assurance mini project

SORA Is a project created for the Information Security and Assurance class
mid-term project assignment.

SORA is an e-money project with features such as transferring cash to other users,
and to purchase certain products and services from our verified vendors
(Such as: Electricity, Water, Etc.)

According to the ISA project requirement that the projects must implement any form
of cryptography or encryption, SORA has several measures of cryptography implemented:

1. Salted and double hashed password stored in the database. The hash method used
on this project is PBKDF2 (or IETF RFC 2898).

2. Encrypted Customer personal data using the encryption method AES-128-CBC.
The key generated to encrypt these personal data is reencrypted with AES with
the derivation of the customer's password hash as key.

3. Each transactions done in SORA would be encrypted with RSA, the public key would
be stored normally in the database, but the private key would be stored
in the same manner that the personal data is stored (Encrypted with AES with the key
being encrypted with the password hash derivation)
