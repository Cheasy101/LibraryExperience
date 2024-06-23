Я использую докер для базы данных. вот докер ран
docker run --hostname=21734802b12f --user=mssql --env=ACCEPT_EULA=Y --env=SA_PASSWORD=P@ssw0rd123! --env=PATH=/usr/local/sbin:/usr/local/bin:/usr/sbin:/usr/bin:/sbin:/bin --env=MSSQL_RPC_PORT=135 --env=CONFIG_EDGE_BUILD= --env=MSSQL_PID=developer --network=bridge -p 1433:1433 --restart=no --label='com.microsoft.product=Microsoft SQL Server' --label='com.microsoft.version=16.0.4125.3' --label='org.opencontainers.image.ref.name=ubuntu' --label='org.opencontainers.image.version=22.04' --label='vendor=Microsoft' --runtime=runc -d mcr.microsoft.com/mssql/server


так же можно было использовать сикреты для подключения к бд;)