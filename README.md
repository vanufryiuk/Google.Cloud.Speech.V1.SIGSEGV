# SIGSEGV in Google.Cloud.Speech.V1

## How to reproduce

```sh
> git clone git@github.com:vanufryiuk/Google.Cloud.Speech.V1.SIGSEGV.git
> cd Google.Cloud.Speech.V1.SIGSEGV
> cp /your/GoogleCredentials.json ./
> docker-compose build
> docker-compose up
```

## Expected

An empty array is printed, zero exit code is returned

## Actual

139 exit code is returned (SIGSEGV)
