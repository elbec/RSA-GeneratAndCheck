![GitHub All Releases](https://img.shields.io/github/downloads/elbec/RSA-GenerateAndCheck/total)
![GitHub release (latest by date)](https://img.shields.io/github/v/release/elbec/RSA-GenerateAndCheck)

# RSA-GenerateAndCheck

The RSA-GenerateAndCheck App can be used for generate and/or check RSA-Keys. The generated signature can be exported as a xml license file.

Tags: RSA, RSA-Key, generate key, check key, private key, public key, encrypt, xml export, database, signature import, signature check, license file creator

![appOverview](https://github.com/elbec/RSA-GenerateAndCheck/blob/master/RSA%20Tool/Documentation/rsa.gif?raw=true)

## Instuction

### How to generate a RSA-Signature with private key:
1. Press the button <kbd>Create Keys</kbd> --> Now you have generated a private and the associated public key.

2. Write the text which should be encoded by the private key in the textbox named "Source Text".

3. Press the button <kbd>Encrypt Source Text</kbd>
RSA-Signature generated and have been saved in the Database.

### How to check the RSA-Signature for validity with the public key:

1. Enter the public key in the "Public Key" text box.
2. Enter the signature in the "Signature" text box.
3. Enter the right source text in the "Source Text" text box.
4. Press the button <kbd>Verify Signature</kbd>
You will now reveice a message whether the signature is valid.

### How to load data form database:

1. Enter the signature in the "Signature" text box.
2. Press the button <kbd>Load Data By Signature</kbd>.
