# CMakeList.txt : projet CMake pour TP3, incluez la source et définissez
# la logique spécifique au projet ici.
#
cmake_minimum_required (VERSION 3.8)

project ("TP3")

# Current directory is ray_sphere_tp2
set(glm_DIR ../librairies/glm/cmake/glm)
find_package(glm REQUIRED )

set(SFML_STATIC_LIBRARIES TRUE)
set(SFML_DIR ../librairies/SFML-2.5.1/lib/cmake/SFML)
find_package(SFML 2.5.1 COMPONENTS graphics window REQUIRED)

# Ajoutez une source à l'exécutable de ce projet.
#add_executable (TP3 "TP3.cpp" "TP3.h"  "Scene.cpp" "Camera.h" "Sphere.cpp")
add_executable (TP3 "TP3.cpp" "TP3.h"  "Ray.h"  "SceneObject.h" "Sphere.h"   "Light.h" "Scene.h" "Scene.cpp" "Camera.h" "Sphere.cpp" "Camera.cpp" )
#add_executable (TP3 "TP3.cpp" "TP3.h" "Lights.cpp" "Rays.cpp")
#add_executable (TP3 "TP3.cpp" "TP3.h"  "Ray.h"  "SceneObject.h" "Sphere.h") ####

target_link_libraries(${PROJECT_NAME} glm::glm)
target_link_libraries(${PROJECT_NAME} sfml-graphics sfml-window)

# TODO: Ajoutez des tests et installez des cibles si nécessaire.



