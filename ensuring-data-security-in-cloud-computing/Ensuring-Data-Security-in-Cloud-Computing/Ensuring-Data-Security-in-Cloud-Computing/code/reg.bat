
set classpath=.;

javac JSplashScreen.java
javac RMISImpl.java
javac Server.java
java RMISImpl
rmic RMISImpl
start rmiregistry
java Server
