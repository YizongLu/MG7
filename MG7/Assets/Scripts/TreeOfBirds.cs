using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!

public class TreeOfBirds :MonoBehaviour
{
    [SerializeField] private GameObject[] _Sparrows;
    [SerializeField] private float _interactionDistance;
    [SerializeField] private Transform _playerTransform;

    private void Update(){
        for(int i=0;i<_Sparrows.Length;i++){
            GameObject _bird=_Sparrows[i];
            if(Vector3.Distance(_playerTransform.position,_bird.transform.position) <= _interactionDistance){
                _bird.SetActive(true);
            }
        }
    }

}
