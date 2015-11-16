FROM microsoft/aspnet:1.0.0-beta8-coreclr
COPY . /app/
WORKDIR /app/approot
EXPOSE 5004
ENV DNX_TRACE=1
RUN chmod +x ./kestrel
RUN chmod +x ./runtimes/dnx-coreclr-linux-x64.1.0.0-beta8/bin/dnx
ENTRYPOINT ["./kestrel"]
