#include "Boundingbox.h"

Boundingbox::Boundingbox(const glm::vec3& center, const glm::float32& radius) : SceneObject(), m_center(center), m_radius(radius)
{
}

//bool Boundingbox::intersect(const Ray& r, glm::vec3& position, glm::vec3& normal)
//{
//	return glm::intersectRayPlane(r.m_origin, r.m_direction, m_center, m_radius, position, normal);
//}