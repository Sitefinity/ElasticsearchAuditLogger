# 	Configure ElasticSearch v1.7.3 and Kibana v4.1.2 #

## ##

## Prerequisites ##



- Download and install *****Java Development Kit*** (JDK)**
[http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html](http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html)
- Set the ***Path Environment variable***
[http://docs.oracle.com/javase/8/docs/technotes/guides/install/windows_jdk_install.html#CHDHHBDD](http://docs.oracle.com/javase/8/docs/technotes/guides/install/windows_jdk_install.html#CHDHHBDD)	
[https://www.youtube.com/watch?v=yrRmLOcB9fg](https://www.youtube.com/watch?v=yrRmLOcB9fg)




##	ElasticSearch Setup and Configuration ##

1.  Download and extract ***Elasticsearch***, version 1.7.3 from [https://www.elastic.co/downloads/past-releases/elasticsearch-1-7-3](https://www.elastic.co/downloads/past-releases/elasticsearch-1-7-3).
In the steps to follow, *%ElasticsearchPath%* refers to the path where your ***Elasticsearch*** files reside.
1. If you want the server to be started on specific port you have to edit the *elasticsearch.yml* file located in *%ElasticsearchPath%**/config* folder.Uncomment and change the port from section *Set a custom port to listen for HTTP traffic:* to the port that you want to use. **Default is 9200.**
1. Start the ***Elasticsearch*** server, either as executable, or as a service:
	- To start ***Elasticsearch*** as an executable, run *%ElasticsearchPath%\bin\elasticsearch.bat*.
	Ensure that *%ElasticsearchPath%\bin\elasticsearch.bat* (*%ElasticsearchPath%/bin/elasticsearch* on Unix) is called on system startup.
	- To start ***Elasticsearch*** as a service, in *%ElasticsearchPath%\bin*, in a command prompt, perform the following:
		- Install the service by typing: *service install*
		- Start the service by typing:  *service start*
1. In Sitefinity's backend, navigate to *Administration » Settings » Advanced Settings » ElasticsearchAudit.*
1. In *ElasticsearchUri* field, enter the root URL of your Elasticsearch site.**Default is 9200.**

## Kibana Setup and Configuration ##

1. Download and extract ***Kibana*** from [https://www.elastic.co/downloads/past-releases/kibana-4-1-2](https://www.elastic.co/downloads/past-releases/kibana-4-1-2).In the steps to follow, %KibanaPath% refers to the path where your Kibana files reside
3. Open the *%KibanaPath%\config\kibana.yml* file for editing.
Locate the *elasticsearch_url:* setting and set it to the root URL of your ***Elasticsearch*** server.**Default is 9200.** 
You can also set which port to be used by ***Kibana*** in the setting - *port*. **Default is 5601.**
1.	Go to %KibanaPath%\bin folder and open the file kibana.bat.This is going to host Kibana on the port set in the configuration file.
1. Open your hosted ***Kibana*** site and you will be asked to configure an index pattern.
2. In the *Index name or pattern* field type ***index.*** 
2. From the *Time-field name* drop-down select ***Timestamp*** and click ***Create*** button
 
#### Dashboard configuration ####
You can load additional Sitefinity searches,visualizations and dashboards files for custom views from this repository.

1. Go to *Settings* and select *Objects* tab.
2. Click the *Import* button and select the provided *Dashboards.json*
3. Now you can go to *Dashboard* tab and from the *Load Saved Dashboard* button in the top right side of the screen and select the dashboard which you want to use. 

**Note:** If you have problems with the loading of *Visualizations* and *Searches* in the *Dashboard* you may need to **Import** *Visualizations.json* and *Searches.json*.



