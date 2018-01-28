## Installation of Mongo

The latest version of mongo can be found at https://www.mongodb.com/download-center#community 

### Configuration

After installing mongo, create a configuration file to manage the installation. Create a file called ```mongod.cfg``` in the bin folder of the mongo installation. Example configuration:

```
systemLog:

destination: file

path: "D:\\Software\\Monggo_installation\\db\\log\\mongo.log"

logAppend: true

storage:

dbPath: "C:\\Software\\Monggo_installation\\db\\data"

security:

authorization: enabled
```

The locations of the log and db files are up to you but make sure to create all of the folders mentioned in the paths as mongo will throw errors when starting if the directories it needs don't exist.

## Running Mongo

From  a command line, run this command pointing to your config file

```batch
mongod.exe -config mongod.cfg
```

### Creating an admin user

Once the database is installed and running, you need to create an admin superuser to manage the mongo database in the installation. In another command line, run mongo.exe (in the mongo installation's bin folder) and run this command:

```batch
db.createUser({ user: "admin",  pwd: "AdminPassword", roles: [ { role: "root", db: "admin" } ]});
```

With a better password. Don't forget this password.

## Creating a database

Once mongod is running, run mongo.exe in another command line, connecting as your admin user:

```batch
mongo.exe admin -u admin -p AdminPassword
```

Asking to use a database which doesn't exist will make mongo create the database

```bacth
use NewDatabaseName
```

### Setup a user for the database

run mongo.exe in a command line.

```bacth
db.createUser({ user: "userName", pwd: "Password", roles: [ { role: "readWrite", db: "DatabaseName" } ]});
```

### Deleting a database

run mongo.exe in a command line.

Connect to the database:

```batch
use DATABASE_NAME

db.dropDatabase()
```

## Viewing data

The databases can be queried in a command line from mongo.exe or from the built in mongo web interface.

Robo 3T is a desktop app that allows viewing of data in the database: https://robomongo.org

