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

int main(int argc, char** argv) 
{ 
    cout << "You have entered " << argc << " arguments:" << "\n"; 
    for (int i = 0; i < argc; ++i){
        cout << argv[i] << "\n"; 
    }

    string s;

    Entity e[3];
    e->setMessage("1st\n");
    cout << e->getMessage() << '\n';
    (e+1)->setMessage("2nd\n");
    cout << (e+1)->getMessage() << '\n';
    (e+2)->setMessage("3rd\n");
    cout << (e+2)->getMessage() << '\n';

    // Entity* f;
    // if (argc > 1){
    //     Entity* g = new Entity(argv[1]);
    //     f = g;
    //     delete g;
    // }
    // else
    // {
    //     Entity* g = new Entity("Empty");
    //     f = g;
    //     delete g;
    // }
    // cout << f->getMessage() << '\n';
    // delete f;
    return 0; 
}
