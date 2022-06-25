using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using System.Collections;

public class EnemyMove : MonoBehaviour
{
    public GameObject TargetObject; /// �ڕW�ʒu
    NavMeshAgent m_navMeshAgent; /// NavMeshAgent
    // Use this for initialization
    void Start()
    {
        // NavMeshAgent�R���|�[�l���g���擾
        m_navMeshAgent = GetComponent<NavMeshAgent>();
    }
    // Update is called once per frame
    void Update()
    {
        // NavMesh�������ł��Ă���Ȃ�
        if (m_navMeshAgent.pathStatus != NavMeshPathStatus.PathInvalid)
        {
            // NavMeshAgent�ɖړI�n���Z�b�g
            m_navMeshAgent.SetDestination(TargetObject.transform.position);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Result");
        }
    }
}