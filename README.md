# examples_cpp_redis
C++ Redis 사용 방법 정리
    
## hiredis 빌드하기
- 저장소: https://github.com/redis/hiredis 
- redis 공식 라이브러리
- C언어
- Windows도 지원한다.
  
### Windows
- CMake GUI 툴을 사용하여 VS 솔루션을 만든다.
- 솔루션을 열어서 빌드한다.
- defule 빌드는 동적 dll을 출력한다.
- 정적 lib을 만들고 싶다면 변경해야 한다.
    
![hiredis_vc](./RedisCpp-hiredis/images/001.png)    
    
        