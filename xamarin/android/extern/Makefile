
all: insertIO-1.41.41.1790.aar jars/dagger-2.1.jar jars/slf4j-android-1.7.6.jar aars/rxandroid-1.1.0.aar aars/rxbinding-0.4.0.aar \
	 aars/rxlifecycle-0.5.0.aar aars/library-1.0.2.aar aars/gifimageview-2.0.0.aar aars/android-iconify-2.2.2.aar

clean:
	rm -rf jars aars insertIO-1.41.41.1790.aar

insertIO-1.41.41.1790.aar:
	curl -L http://software.insert.io/artifactory/android-release/sdk/insert/io/insertIO/1.41.41.1790/insertIO-1.41.41.1790.aar -o insertIO-1.41.41.1790.aar
	touch $@

jars/slf4j-android-1.7.6.jar:
	mkdir -p jars
	curl -L https://jcenter.bintray.com/org/slf4j/slf4j-android/1.7.6/slf4j-android-1.7.6.jar -o jars/slf4j-android-1.7.6.jar
	touch $@

jars/dagger-2.1.jar:
	mkdir -p jars
	curl -L https://jcenter.bintray.com/com/google/dagger/dagger/2.8/dagger-2.8.jar -o jars/dagger-2.8.jar
	curl -L https://jcenter.bintray.com/com/jakewharton/timber/timber/3.0.1/timber-3.0.1.jar -o jars/timber-3.0.1.jar
	curl -L https://jcenter.bintray.com/com/squareup/picasso/picasso/2.5.2/picasso-2.5.2.jar -o jars/picasso-2.5.2.jar
#	curl -L https://jcenter.bintray.com/com/squareup/okio/okio/1.6.0/okio-1.6.0.jar -o jars/okio-1.6.0.jar
	#Maybe delete those two lines, in case we've got it from the nuget references.
	curl -L https://jcenter.bintray.com/com/squareup/okhttp3/okhttp/3.4.1/okhttp-3.4.1.jar -o jars/okhttp-3.4.1.jar
	curl -L https://jcenter.bintray.com/com/squareup/okhttp3/okhttp-ws/3.4.1/okhttp-ws-3.4.1.jar -o jars/okhttp-ws-3.4.1.jar
	#Added nineoldandroids
	curl -L http://central.maven.org/maven2/com/nineoldandroids/library/2.4.0/library-2.4.0.jar -o jars/nineoldandroids-2.4.0.jar
#	curl -L https://jcenter.bintray.com/io/socket/engine.io-client/0.7.0/engine.io-client-0.7.0.jar -o jars/engine.io-client-0.7.0.jar
	curl -L https://jcenter.bintray.com/io/socket/socket.io-client/0.7.0/socket.io-client-0.7.0.jar -o jars/socket.io-client-0.7.0.jar
	curl -L https://jcenter.bintray.com/io/reactivex/rxjava/1.1.1/rxjava-1.1.1.jar -o jars/rxjava-1.1.1.jar
	curl -L https://jcenter.bintray.com/com/google/code/gson/gson/2.6.2/gson-2.6.2.jar -o jars/gson-2.6.2.jar
	curl -L https://jcenter.bintray.com/com/squareup/retrofit2/retrofit/2.1.0/retrofit-2.1.0.jar -o jars/retrofit-2.1.0.jar
	curl -L https://jcenter.bintray.com/com/squareup/retrofit2/adapter-rxjava/2.1.0/adapter-rxjava-2.1.0.jar -o jars/adapter-rxjava-2.1.0.jar
	curl -L https://jcenter.bintray.com/org/apache/commons/commons-lang3/3.4/commons-lang3-3.4.jar -o jars/commons-lang3-3.4.jar
	curl -L https://jcenter.bintray.com/org/slf4j/slf4j-api/1.7.6/slf4j-api-1.7.6.jar -o jars/slf4j-api-1.7.6.jar
	curl -L https://jcenter.bintray.com/org/bitbucket/b_c/jose4j/0.4.4/jose4j-0.4.4.jar -o jars/jose4j-0.4.4.jar
	curl -L http://software.insert.io/artifactory/android-sdk-externals/com/google/andorid/youtube/YouTubeAndroidPlayerApi/0.1/YouTubeAndroidPlayerApi-0.1.jar -o jars/YouTubeAndroidPlayerApi-0.1.jar
	curl -L https://jcenter.bintray.com/javax/inject/javax.inject/1/javax.inject-1.jar -o jars/javax.inject-1.jar
	touch $@

aars/rxandroid-1.1.0.aar:
	mkdir -p aars
	curl -L https://jcenter.bintray.com/io/reactivex/rxandroid/1.1.0/rxandroid-1.1.0.aar -o aars/rxandroid-1.1.0.aar
	unzip aars/rxandroid-1.1.0.aar -d aars/rxandroid-1.1.0
	cp aars/rxandroid-1.1.0/classes.jar aars/rxandroid-1.1.0.jar
	touch $@

aars/rxbinding-0.4.0.aar:
	mkdir -p aars
	curl -L https://jcenter.bintray.com/com/jakewharton/rxbinding/rxbinding/0.4.0/rxbinding-0.4.0.aar -o aars/rxbinding-0.4.0.aar
	unzip aars/rxbinding-0.4.0.aar -d aars/rxbinding-0.4.0
	cp aars/rxbinding-0.4.0/classes.jar aars/rxbinding-0.4.0.jar
	touch $@

aars/rxlifecycle-0.5.0.aar:
	mkdir -p aars
	curl -L https://jcenter.bintray.com/com/trello/rxlifecycle/0.5.0/rxlifecycle-0.5.0.aar -o aars/rxlifecycle-0.5.0.aar
	unzip aars/rxlifecycle-0.5.0.aar -d aars/rxlifecycle-0.5.0
	cp aars/rxlifecycle-0.5.0/classes.jar aars/rxlifecycle-0.5.0.jar
	touch $@

aars/library-1.0.2.aar:
	mkdir -p aars
	curl -L https://jcenter.bintray.com/com/daimajia/easing/library/1.0.2/library-1.0.2.aar -o aars/library-1.0.2.aar
	unzip aars/library-1.0.2.aar -d aars/library-1.0.2
	cp aars/library-1.0.2/classes.jar aars/library-1.0.2.jar
	touch $@

aars/gifimageview-2.0.0.aar:
	mkdir -p aars
	curl -L https://jcenter.bintray.com/com/felipecsl/gifimageview/2.0.0/gifimageview-2.0.0.aar -o aars/gifimageview-2.0.0.aar
	unzip aars/gifimageview-2.0.0.aar -d aars/gifimageview-2.0.0
	cp aars/gifimageview-2.0.0/classes.jar aars/gifimageview-2.0.0.jar
	touch $@

aars/android-iconify-2.2.2.aar:
	mkdir -p aars
	curl -L https://jcenter.bintray.com/com/joanzapata/iconify/android-iconify/2.2.2/android-iconify-2.2.2.aar -o aars/android-iconify-2.2.2.aar
	unzip aars/android-iconify-2.2.2.aar -d aars/android-iconify-2.2.2
	cp aars/android-iconify-2.2.2/classes.jar aars/android-iconify-2.2.2.jar
	touch $@
	