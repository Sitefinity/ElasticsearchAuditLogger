**ElasticSearch Setup and Configuration**

1. Download and extract **Elasticsearch**, version **8.11.0**, from [https://www.elastic.co/downloads/past-releases/elasticsearch-8-11-0](https://www.elastic.co/downloads/past-releases/elasticsearch-8-11-0). In the steps to follow, _%ElasticsearchPath%_ refers to the path where your **Elasticsearch** files reside.
2. If you want the server to be started on specific port you have to edit the _elasticsearch.yml_ file located in _%ElasticsearchPath%\*\*/config_ folder. Uncomment and change the port from section _Set a custom port to listen for HTTP traffic:_ to the port that you want to use. The default port is **9200.**
3. Start the **Elasticsearch** server, either as executable, or as a service:
  - To start **Elasticsearch** as an executable, run _%ElasticsearchPath%\bin\elasticsearch.bat_. Ensure that _%ElasticsearchPath%\bin\elasticsearch.bat_ (_%ElasticsearchPath%/bin/elasticsearch_ on Unix) is called on system startup.
  - To start **Elasticsearch** as a service, in _%ElasticsearchPath%\bin_, in a command prompt, perform the following:
    - Install the service by typing: _service install_
    - Start the service by typing: _service start_
4. In Sitefinity&#39;s backend, navigate to _Administration » Settings » Advanced Settings » ElasticsearchAudit._
5. In _ElasticsearchUri_ field, enter the root URL of your Elasticsearch site.

**Kibana Setup and Configuration**

1. Download and extract **Kibana** **8.11.3** from [https://www.elastic.co/downloads/past-releases/kibana-8-11-3](https://www.elastic.co/downloads/past-releases/kibana-8-11-3) .In the steps to follow, %KibanaPath% refers to the path where your Kibana files reside
2. Open the _%KibanaPath%\config\kibana.yml_ file for editing. Locate the _elasticsearch\_url:_ setting and set it to the root URL of your **Elasticsearch** server. **Default is 9200.** You can also set which port to be used by **Kibana** in the setting - _port_. **Default is 5601.**
3. Go to %KibanaPath%\bin folder and open the file kibana.bat. This is going to host Kibana on the port set in the configuration file.
4. Open your hosted **Kibana** site and you will be asked to configure an index pattern.
5. In the _Index name or pattern_ field type **index.**
6. From the _Time-field name_ drop-down select **Timestamp** and click **Create** button

**Dashboard configuration**

You can load additional Sitefinity searches, visualizations and dashboards files for custom views from this repository.

1. Go to _Settings_ and select _Objects_ tab.
2. Click the _Import_ button and select the provided _Dashboards.json_
3. Now you can go to _Dashboard_ tab and from the _Load Saved Dashboard_ button in the top right side of the screen and select the dashboard which you want to use.

**Note:** If you have problems with the loading of _Visualizations_ and _Searches_ in the _Dashboard_ you may need to **Import** _Visualizations.json_ and _Searches.json_.
