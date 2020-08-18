#include <iostream>
using namespace std;

class Entity{
	public:
	Entity();
	Entity(string message);
	~Entity();
	void setMessage(string message);
	string getMessage();
	void toOutput(string message);
	private:
	string _message;
};
Entity::Entity(){
	printf("Creating Constructor\n");
}
Entity::Entity(string message):_message(message){
	printf("Creating Constructor\n");
}
void Entity::setMessage(string message){
	_message = message;
}
string Entity::getMessage(){
	return _message;
}
void Entity::toOutput(string message){
	cout << "The message output is: " << message << "\n";
}
Entity::~Entity(){
	printf("Destructor Called\n");
}

int main(){
	string s;

	Entity e;
	e.setMessage("Hello World");
	s = e.getMessage();
	cout << e.getMessage() << '\n';
	cout << s << '\n';
	e.toOutput(s);

	Entity f("Hello World");
	s = f.getMessage();
	cout << f.getMessage() << '\n';
	cout << s << '\n';
	e.toOutput(s);

	return 0;
}