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

1. The following text is printed:

    ```txt
    You can see this line.
    But you can't see this one.
    ```

2. 0 exit code (SUCCESS) is returned

## Actual

1. The following text is printed:

    ```txt
    You can see this line.
    ```

2. 139 exit code (SIGSEGV) is returned
