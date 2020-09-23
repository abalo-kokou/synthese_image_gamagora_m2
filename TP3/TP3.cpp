// TP3.cpp : définit le point d'entrée de l'application.
//
#include <glm/glm.hpp>
#include <glm/gtx/intersect.hpp>
#include <SFML/Graphics.hpp>

#include "TP3.h"

#include "Ray.h"
#include "SceneObject.h"
#include "Sphere.h"
#include "Light.h"
#include "Camera.h"
#include "Scene.h"


using namespace std;

int main()
{
    unsigned int width = 1000;
    unsigned int height = 800;

    Scene scene(width, height, Camera(glm::vec3(0, 0, 0), glm::vec3(0, 0, 1)), sf::Color(0, 0, 0, 125)); // Create scene with camera (at a fixed position) and a background color
    scene.renderImage("../../../output.png");

    sf::Texture texture;
    texture.loadFromImage(scene.getImage());  //Load Texture from image

    sf::Sprite sprite;
    sprite.setTexture(texture);

    sf::RenderWindow window(sf::VideoMode(width, height), "RAYTRACER");

    while (window.isOpen()) {

        sf::Event event;

        while (window.pollEvent(event))
        {
            if (event.type == sf::Event::Closed)
                window.close();

        }//Event handling done

        window.clear();
        window.draw(sprite);
        window.display();

    }

}
